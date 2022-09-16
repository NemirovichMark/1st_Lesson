using System;
using System.Runtime.Intrinsics.X86;

namespace _0_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (height > 0)
            {
                if (weight > 0)
                {
                    double BMI = (weight / Math.Pow(height, 2)) * 10000;
                    Console.WriteLine($"Your BMI: {BMI}");
                }
            }
            else
            {
                Console.WriteLine($"Mistake");
            }
            #endregion

            #region Task 2
            double a = 100 % 17;
            double b = 18.0 - (a / 17.0);
            double grad = 10.0 * 17.0;
            double pi = 3.14;
            double l = pi * (a + b);
            double answer = (l * grad) / 360;
            Console.WriteLine(answer);
            #endregion

            #region Task 3
            int a0 = 17;
            int s = 12604;
            Console.Write("Enter the number of the progression member: ");
            string? input  = Console.ReadLine();
            if (int.TryParse(input, out var number) == true)
            {
                int n = Convert.ToInt32(input);
                if (n >= 2)
                {
                    double an = ((2 * s) / n) - a0;
                    double d = (an - a0) / (n - 1);
                    Console.WriteLine($"nth term of an Arithmetic Sequence: {an}");
                    Console.WriteLine($"step of an Arithmetic Sequence: {d}");
                }
                else
                {
                    Console.WriteLine($"It is impossible to make a progression");
                }
            }
            else
            {
                Console.WriteLine($"Enter an integer");
            }
            #endregion
        }
    }
}
