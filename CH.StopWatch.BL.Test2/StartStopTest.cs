using System.Security.Cryptography.X509Certificates;

namespace CH.StopWatch.BL.Test
{
    [TestClass]
    public class StartStopTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //instantiating the class
            StartStop startStop = new StartStop();

            //calling the method 
            startStop.StartingClock();

            //Thread sleep means wait for however period of time 
            Thread.Sleep(1000);

            //if the elapsed time equals 0 it will fail showing that the clock never started 
            if (startStop.ElapsedTime == DateTime.Now - DateTime.Now) Assert.Fail();
        }



        [TestMethod]
        public void TestMethod2()

        {

           
            //creating variables to hold the DateTime
            DateTime DateTime;
            DateTime DateTime2;

            StartStop startStop = new StartStop();

            //Need to call the Starting Clock method because if it is not called first it will throw the exception
            // It is like presssing the stop button without running anything
            startStop.StartingClock();
            DateTime = DateTime.Now;
            //waitng for 1 second before the test starts 
            Thread.Sleep(1000);

            //Stopping the clock
            startStop.StopClock();


            DateTime2 = DateTime.Now;

            //If it is not true then it throws out the message
            //if /*(DateTime != DateTime2)*/ 
             Assert.IsTrue(DateTime != DateTime2, "Pass");

        }
    }
}