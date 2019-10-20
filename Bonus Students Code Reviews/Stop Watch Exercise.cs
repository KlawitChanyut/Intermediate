﻿using System;
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
                stopwatch.Start();

                Thread.Sleep(1000);

                //stopwatch.Start(Datetime.Now);

                stopwatch.Stop();

                Console.WriteLine("Duration: " + stopwatch.GetInterval());

                Console.WriteLine("Press Enter to run the stopwatch noe more time.");
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
            
                throw new InvalidOperationException("Stopwatch is already running!");
                
                     
            _startTime = DateTime.Now;
            _running = true;           
        }

        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("Stopwatch is not running!");
            
            
            _endTime = DateTime.Now;
            _running = false;
            
        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }
    }
}
