using System;

namespace _05.DataMod
{
    public class DateModifier
    {
        public double DifferenceInDates(DateTime first, DateTime last)
        {
            return Math.Abs((last - first).TotalDays); 
        }
    }
}
