using System;
using System.IO;

namespace IPP_lb1.BL
{
    /// <summary>
    /// Save time of creation of thread and allows to get active time of thread
    /// </summary>
    public class Time : ITime
    {
        public DateTime StartTime { get; set; }

        public Time(DateTime? startTime = null)
        {
            if (startTime != null) StartTime = (DateTime)startTime;
        }
        
        public TimeSpan GetSubtractTime()
        {
            return (DateTime.Now - StartTime).Duration();
        }
    }
}