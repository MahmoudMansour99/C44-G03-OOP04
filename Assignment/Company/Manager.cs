using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Company
{
    internal class Manager : Employee
    {
        #region Methods
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Manager is Managing");
        }
        #endregion
    }
}
