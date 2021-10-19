using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class StopwatchSimulator
    {
        public int? timer()
        {
            // creating a stopwatch object from the predefined stopwatch class
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Please enter any key to start the stopwatch");
            Console.WriteLine();
            Console.ReadKey();
            //below start method starts the stopwatch
            stopwatch.Start();     
            Console.WriteLine("****Running**** Press any key to stop and display stopwatch time");
            Console.WriteLine();
            Console.ReadKey();
            // the stop method ends the stopwatch
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
            return null; 
        }
    }
}
