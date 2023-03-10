using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.StopWatch.BL
{
    public class StartTimeException : Exception
    {
        public StartTimeException()
            : base("The Stop Watch is already running")
        { }
    }
}
