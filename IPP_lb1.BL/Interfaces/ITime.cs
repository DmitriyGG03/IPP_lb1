using System;

namespace IPP_lb1.BL
{
    public interface ITime
    {
        DateTime StartTime { get; set; }

        TimeSpan GetSubtractTime();
    }
}