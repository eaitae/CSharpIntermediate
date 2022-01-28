using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch
{
    public class Stopwatch
    {
        public DateTime Start { get; private set; }
        public DateTime Stop { get; set; }
        public TimeSpan Duration { get; set; }
        private Boolean Running;

        public void StartStopwatch()
        {
            if (Running)
            {
                throw new InvalidOperationException("Cannot start: already running");
            }

            Start = DateTime.Now;
            Running = true;

        }

        public void StopStopwatch()
        {
            if (!Running)
            {
                throw new InvalidOperationException("Cannot stop: not running");
            }

            Stop = DateTime.Now;
            Running = false;

        }

        public TimeSpan DurationStopwatch()
        {
            Duration = Stop - Start;
            return Duration;
        }
    }
}
