using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate.Bonus_Students
{
    public class Stop_Watch_Exercise
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            for (var i = 0; i < 2; i++)
            {
                stopwatch.Start(DateTime.Now);

                for (var l = 0; j <= 1000; j++)
                {
                    Thread.Sleep(1);
                }

                //stopwatch.Start(Datetime.Now);

                stopwatch.Stop(DateTime.Now);

                Console.WriteLine(stopwatch.GetInterval().ToString());
                Console.ReadLine();
            }
        }
    }

    public class StopWatch
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        private bool running = false;

        public void Start(DateTime start)
        {

        }
    }
}
