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
            Complex C01 = new Complex(8, 9);
            Complex C02 = new Complex(5, 7);

            Complex Sum = C01 + C02;
            Complex Sub = C01 - C02;

            Console.WriteLine($"Sum of the Complex is {Sum.Real} + {Sum.Imag}i");
            Console.WriteLine($"Sub of the Complex is {Sub.Real} - {Sub.Imag}i");
            #endregion

            #endregion



        }
    }
}
