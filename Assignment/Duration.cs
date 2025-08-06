using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Duration
    {
        #region Properties
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Constructor
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;

            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            string result = "";

            if (Hours > 0)
                result += $"Hours: {Hours}, ";
            if (Minutes > 0 || Hours > 0)
                result += $"Minutes: {Minutes}, ";
            result += $"Seconds: {Seconds}";

            return result;
        }

        //public override string ToString()
        //{
        //    return $"{Hours}:{Minutes}:{Seconds}";
        //}


        //public override bool Equals(object obj)
        //{
        //    if (obj is Duration other)
        //    {
        //        return Hours == other.Hours &&
        //               Minutes == other.Minutes &&
        //               Seconds == other.Seconds;
        //    }
        //    return false;
        //}
        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Hours, Minutes, Seconds);
        //}
        #endregion
    }
}
