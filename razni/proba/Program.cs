using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace proba
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = Stopwatch.StartNew();
            // CPU is maxed out during this call.
            // ... (Try making it much larger to test.)
            Thread.SpinWait(1000000);
            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
        }
    }
}
