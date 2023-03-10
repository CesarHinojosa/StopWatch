using System.Data;
using System.Runtime.InteropServices;

namespace CH.StopWatch.BL
{
    public class StartStop
    {

        //fields

        public DateTime startTime = DateTime.MinValue;

        public DateTime stopTime = DateTime.MinValue;


        //Holds the info for a brief moment 
        public TimeSpan elapsedtime;

        //By deafult it is not running 
        bool IsRunning = false;

        bool Cleared = true;

        bool stopped = true;

        public TimeSpan ElapsedTime
        {
            get
            {
                if (IsRunning && !Cleared)
                {
                    // Clock is running
                    return DateTime.Now - startTime;
                }
                else if (!IsRunning && !Cleared)
                {
                    // Clock has been stopped
                    return stopTime - startTime;
                    
                }
                
                // Clock has not been started or has been cleared
                return elapsedtime;
            }
        }

        public void StartingClock()
        {
            if (IsRunning && !Cleared)
            {
                // Clock is already running
                throw new StartTimeException();
            }

            else if (Cleared)
            {
                // Start the clock
                startTime = DateTime.Now;
                IsRunning = true;
                Cleared = false;
            }
          
        }

        public void StopClock()
        {
            if (!IsRunning)
            {
                // Clock is not running
                throw new StopTimeException();
            }
            else if(IsRunning &&  !Cleared)
            {
                // Stop the clock
                stopTime = DateTime.Now;
                stopped = true;
                IsRunning = false;
            } 
        }

        public void Reset()
        {
            if (!IsRunning && !Cleared)
            {
                elapsedtime = TimeSpan.Zero;
                IsRunning= false;
                Cleared = true;
            }
        }

    }
}