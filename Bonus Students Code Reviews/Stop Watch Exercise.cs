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
                stopwatch.Start(DateTime.Today.AddDays(1));

                for (var j = 0; j <= 1000; j++)
                {
                    Thread.Sleep(1);
                }

    
                //stopwatch.Start(Datetime.Now);

                stopwatch.Stop(DateTime.Today.AddYears(-1));

                Console.WriteLine(stopwatch.GetInterval().ToString());
                Console.ReadLine();
            }
        }
    }

    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;

        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException("Stopwatch is already running!");
                
            }
            else
            {
                _startTime = DateTime.Now;
                _running = true;
            }
        }

        public void Stop()
        {
            if (_running)
            {
                _endTime = DateTime.Now;
                _running = false;
            }
        }

        public TimeSpan GetInterval()
        {
            var duration = _endTime - _startTime;

            return duration;
        }
    }
}
