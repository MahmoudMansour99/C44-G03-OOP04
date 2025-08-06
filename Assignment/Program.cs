namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:

            Calculator calc = new Calculator();

            Console.WriteLine(calc.Add(5, 10));
            Console.WriteLine(calc.Add(5, 10, 15));
            Console.WriteLine(calc.Add(5.5, 9.5));

            #endregion
        }
    }
}
