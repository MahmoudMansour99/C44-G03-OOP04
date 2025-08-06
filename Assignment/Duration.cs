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
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{Hours}:{Minutes}:{Seconds}";
        }
        #endregion
    }
}
