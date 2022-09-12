using System;
namespace _1st
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            int weight = 71;
            double height = 1.75;

            double BMI = (weight / (height * height));
            Console.WriteLine($"My BMI is {BMI}");

            #endregion

            #region Task 2

            double a = 100 % 11;
            double b = 19 - (a / 11);
            int grad = 10 * 11;
            const double pi = 3.14;
            double AllLength, result;
            AllLength = 4 * ((pi * a * b) + Math.Pow(a - b, 2)) / (a + b);
            result = AllLength / 360 * grad;

            Console.WriteLine($"The length is {result}");

            #endregion

            #region Task 3

            int a0 = 11;
            int S = 5052004;
            int n = int.Parse(Console.ReadLine());
            double an = (2 * S / n) - a0;
            double d = (an - a0) / (n - 1);
            Console.WriteLine($"Step is {d} and nth term is {an}");

            #endregion
        }
    }
}
