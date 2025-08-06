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
        public int TotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
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

        #region Operators Overloading
        public static Duration operator +(Duration left, Duration right)
        {
            return new Duration(
                left.Hours + right.Hours,
                left.Minutes + right.Minutes,
                left.Seconds + right.Seconds
            );
        }
        public static Duration operator +(Duration d, int seconds)
        {
            int totalSeconds = d.TotalSeconds() + seconds;
            return new Duration(totalSeconds);
        }
        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds; 
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            int result = d1.TotalSeconds() - d2.TotalSeconds();
            result = Math.Max(0, result); 
            return new Duration(result);
        }
        public static Duration operator ++(Duration d)
        {
            return new Duration(d.TotalSeconds() + 60);
        }
        public static Duration operator --(Duration d)
        {
            int result = d.TotalSeconds() - 60;
            result = Math.Max(0, result);
            return new Duration(result);
        }
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() > d2.TotalSeconds();
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() < d2.TotalSeconds();
        }
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.TotalSeconds() <= d2.TotalSeconds();
        }
        public static bool operator true(Duration d)
        {
            return d.TotalSeconds() > 0;
        }
        public static bool operator false(Duration d)
        {
            return d.TotalSeconds() == 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
        #endregion
    }
}
