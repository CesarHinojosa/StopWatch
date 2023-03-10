using System.Data;

namespace CH.StopWatch.BL
{
    public class StartStop
    {

        //fields

        public DateTime startTime = DateTime.MinValue;
        public TimeSpan elapsedtime;


        bool IsRunning = false;


        //property
        public TimeSpan ElapsedTime 
        { get 
            {
                if(!IsRunning)
                {
                    return DateTime.Now - startTime;
                    IsRunning = false;
                    
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
    }
}