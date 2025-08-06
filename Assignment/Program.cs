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

            #region 1-Define Class Duration To include Three Attributes Hours, Minutes and Seconds.                              2-Override All System. Object Members [To String(), Equals(),GetHashCode() ] .                                    3-Define All Required Constructors to Produce this output:
            //Duration D01 = new Duration(1, 10, 15);
            //Duration D02 = new Duration(1, 10, 15);
            //Duration D03 = new Duration(1, 25, 55);

            //Console.WriteLine($"D1 = {D01}");
            //Console.WriteLine($"D2 = {D02}");
            //Console.WriteLine($"D3 = {D03}");

            //Console.WriteLine(D01.Equals(D02));  
            //Console.WriteLine(D01.Equals(D03));
            //Console.WriteLine(D02.Equals(D03));

            //Console.WriteLine($"Hash of D01: {D01.GetHashCode()}");
            //Console.WriteLine($"Hash of D02: {D02.GetHashCode()}");
            //Console.WriteLine($"Hash of D03: {D03.GetHashCode()}");

            //Duration D01 = new Duration(1, 10, 15);
            //Duration D02 = new Duration(3600);
            //Duration D03 = new Duration(7800);
            //Duration D04 = new Duration(666);

            //Console.WriteLine(D01.ToString());
            //Console.WriteLine(D02.ToString());
            //Console.WriteLine(D03.ToString());
            //Console.WriteLine(D04.ToString());

            Duration D1 = new Duration(4, 15, 25);
            Duration D2 = new Duration(2, 0, 0);
            Duration D3;

            D3 = D1 + D2;
            Console.WriteLine("D1 + D2 = " + D3);

            D3 = D1 + 7800;
            Console.WriteLine("D1 + 7800 = " + D3);

            D3 = 666 + D3;
            Console.WriteLine("666 + D3 = " + D3);

            D3 = ++D1;
            Console.WriteLine("++D1 = " + D3);

            D3 = --D2;
            Console.WriteLine("--D2 = " + D3);

            D1 = D1 - D2;
            Console.WriteLine("D1 - D2 = " + D1);

            if (D1 > D2)
                Console.WriteLine("D1 is greater than D2");

            if (D1 <= D2)
                Console.WriteLine("D1 is less than or equal to D2");

            if (D1)
                Console.WriteLine("D1 is not zero");

            DateTime obj = (DateTime)D1;
            Console.WriteLine("Converted to DateTime: " + obj);

            #endregion

            #endregion

        }
    }
}
