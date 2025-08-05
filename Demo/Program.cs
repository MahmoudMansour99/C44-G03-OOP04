namespace Demo
{
    internal class Program
    {
        static int SumNumbers(int x, int y)
        {
            return x + y;
        }
        static int SumNumbers(int x, int y, int z)
        {
            return x + y + z;
        }
        static double SumNumbers(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            #region Polymorphism

            #endregion

            #region Methods Overloading

            //double A = 10.2, B = 20.3, C = 30;

            ////int Result = SumTwoNumbers(A, B);
            ////int Result = SumThreeNumbers(A, B, C);
            //double Result = SumNumbers(10, 20, 30);

            //Console.WriteLine(Result);

            #endregion
        }
    }
}
