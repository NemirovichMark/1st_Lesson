using System;

namespace _0_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            {
                double Weight = 67;
                double Height = 1.84;
                Console.WriteLine(Weight / (Height * Height));
            }
            #endregion

            #region Task 2
            {
                int NumberInGitHub, Age, a;
                double Grad, b, Result, WholeLength;
                const double Pi = 3.14;
                NumberInGitHub = 23;
                Age = 18;
                a = 100 % NumberInGitHub;
                b = Age - (a / NumberInGitHub);
                Grad = 10 * NumberInGitHub;
                WholeLength = 2 * Pi * Math.Sqrt((a * a + b * b) / 2);
                Result = WholeLength * Grad / 360;
                Console.WriteLine("Answer " + Result);
            }
            #endregion
            #region Task 3
            {
                int a0 = 23;
                int S = 12804;
                if (int.TryParse(Console.ReadLine(), out int N) & N > 0)
                {
                    double aN, d;
                    aN = (2 * S / N) - a0;
                    d = (aN - a0) / (N - 1);
                    Console.WriteLine($"The last term of an Arithmetic Sequence is {aN} and the step is {d}.");
                }
                else
                {
                    Console.WriteLine("Something went wrong");
                }
            }
            #endregion
        }
    }
}
