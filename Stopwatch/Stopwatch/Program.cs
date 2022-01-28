using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            while (true)
            {
                WriteLine("Type '1' to start the stopwatch \nType '2' to stop the stopwatch \n '3' to exit");
                var input = ReadLine();


                if (input == "1")
                {
                    stopwatch.StartStopwatch();
                    WriteLine(stopwatch.Start.ToString("hh:mm:ss"));
                }

                else if (input == "2")
                {
                    stopwatch.StopStopwatch();
                    WriteLine(stopwatch.Stop.ToString("hh:mm:ss"));
                    break;
                }

                else if (input == "3")
                {
                    break; 
                }

                else
                    WriteLine("Invalid Option");
                continue; 

            }

            WriteLine("Result: " + stopwatch.DurationStopwatch());

                
        }
    }

 
}
