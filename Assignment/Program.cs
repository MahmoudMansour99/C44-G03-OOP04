using Assignment.Base_Class;
using Assignment.Company;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:

            //Calculator calc = new Calculator();

            //Console.WriteLine(calc.Add(5, 10));
            //Console.WriteLine(calc.Add(5, 10, 15));
            //Console.WriteLine(calc.Add(5.5, 9.5));

            #endregion

            #region Q2) Create a class named Rectangle with the following constructors:
            //Rectangle R1 = new Rectangle();
            //Rectangle R2 = new Rectangle(10, 20);
            //Rectangle R3 = new Rectangle(15);

            //Console.WriteLine($"R1: {R1.Width}, {R1.Height}");
            //Console.WriteLine($"R2: {R2.Width}, {R2.Height}");
            //Console.WriteLine($"R3: {R3.Width}, {R3.Height}");
            #endregion

            #region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
            //Complex C01 = new Complex(8, 9);
            //Complex C02 = new Complex(5, 7);

            //Complex Sum = C01 + C02;
            //Complex Sub = C01 - C02;

            //Console.WriteLine($"Sum of the Complex is {Sum.Real} + {Sum.Imag}i");
            //Console.WriteLine($"Sub of the Complex is {Sub.Real} - {Sub.Imag}i");
            #endregion

            #region Quetsion A) Create a base class named Employee with method That Work as it prints "Employee is  working". b) Create a derived class named Manager that overrides the Work method to print "Manager is managing". 
            //Employee employee = new Employee();
            //Manager manager = new Manager();
            //employee.Print();
            //manager.Print();
            #endregion
            #region Question 5)  a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass". b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword. C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.
            //BaseClass baseClass = new BaseClass();
            //DerivedClass1 derivedClass1 = new DerivedClass1();
            //DerivedClass2 derivedClass2 = new DerivedClass2();

            //baseClass.DisplayMessage();
            //derivedClass1.DisplayMessage();
            //derivedClass2.DisplayMessage();
            #endregion
            #endregion

            #region Part 02

            #region 1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
            Duration duration = new Duration(1, 10, 15);
            Console.WriteLine(duration.ToString());
            #endregion

            #endregion

        }
    }
}
