using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            double bmi = (70 / (1.8*1.8));
            Console.WriteLine($"My BMI is {bmi}");
            #endregion

            #region 2
            double a = Math.Pow(100 % 24, 2);
            double b = Math.Pow(18 - (a / 24), 2);
            double grad = 10 * 24;
            double sin = Math.Pow(Math.Sin(grad) * (180 / Math.PI), 2);
            double cos = Math.Pow(Math.Cos(grad) * (180 / Math.PI), 2);
            double answer = Math.Sqrt(a * sin + b * cos);
            Console.WriteLine($"Length is {answer}");

            #endregion 

            #region 3
            int a0 = 24;
            int s = 13103;
            int n;
            Console.WriteLine("Type the n");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                double d = (2.0 * s - 2.0 * a0 * n) / (n * (n - 1.0));
                double an = 2.0 * s / n - a0;
                Console.WriteLine($"D is {d} and An is {an}");
            }
            #endregion
        }
    }
}
