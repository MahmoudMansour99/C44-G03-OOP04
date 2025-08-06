using Demo.Overloading;

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

            #region Operators Overloading
            Complex C1 = new Complex() { Real = 10, Img = 5 };

            Console.WriteLine($"C1 = {C1}");

            Complex C2 = new Complex() { Real = 6, Img = 2 };
            Console.WriteLine($"C2 = {C2}");

            //Complex C3 = default; // ! Null Fordiveness Operator

            //Complex C3 = null + C2;
            //Complex C3 = C1 + C2;
            Complex C3 = C1 - C2;
            Console.WriteLine("============");
            Console.WriteLine($"C3 = {C3}");

            Console.WriteLine(C3++);
            Console.WriteLine(++C3);
            Console.WriteLine(--C3);
            Console.WriteLine(C3--);
            #endregion
        }
    }
}
