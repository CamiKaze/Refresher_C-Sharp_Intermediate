using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        // 2) Stores the system time from the Stopwatch method.
        public DateTime StartWatch { get; set; }
        public DateTime StopWatch { get; set; }

        // 1) Sets the start at DateTime.Now.
        public void Start (DateTime start)
        {
            StartWatch = start;
        }

        public void Stop (DateTime stop)
        {
            StopWatch = stop;
        }

        // 3)
        public double ElapsedTime
        {
            get 
            {
                var timeSpan = StopWatch - StartWatch;
                var milli = timeSpan.TotalMilliseconds;

                return milli;
            }
        }
    }
}
