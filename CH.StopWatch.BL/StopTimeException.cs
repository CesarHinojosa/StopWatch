using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.StopWatch.BL
{
    public class StopTimeException : Exception
    {
        public StopTimeException()
            : base("The Stop Watch needs to start before it is stopped")
        { }
    }
}
