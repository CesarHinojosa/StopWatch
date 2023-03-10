using System.Data;

namespace CH.StopWatch.BL
{
    public class StartStop
    {

        //fields

        public DateTime startTime = DateTime.MinValue;

        public DateTime stopTime = DateTime.MinValue;


        //Holds the info for a brief moment 
        public TimeSpan elapsedtime;


        bool IsRunning = false;


        //property
        public TimeSpan ElapsedTime 
        { get 
            {
                if(!IsRunning)
                {
                    return DateTime.Now - startTime;

                }
                else if (IsRunning)
                {
                    return stopTime - DateTime.Now;
                }
                return elapsedtime;
            }
            
        }

        public void StartingClock()
        {
            if(IsRunning == false)
            {
                startTime= DateTime.Now;
                
            }
            else 
            {
                throw new StartTimeException();
            }
        }

        public void StopClock()
        {
            if (IsRunning == true)
            {
                stopTime= DateTime.Now;
            }
            else
            {
                throw new StopTimeException();
            }
        }
    }
}