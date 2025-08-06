using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Complex
    {
        #region Properties
        public int Real { get; set; }
        public int Imag { get; set; }
        #endregion

        #region Constructor
        public Complex(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }
        #endregion

        #region Overload Operator
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real+b.Real, a.Imag+b.Imag);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imag - b.Imag);
        }
        #endregion
    }
}
