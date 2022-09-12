using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            double bmi = (70 / (1.8 * 1.8));
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
            int n;
            int a0 = 24;
            Console.WriteLine("Type the n");
            if (Int32.TryParse(Console.ReadLine(), out n) && n > 1)
            {
                int s = 13103;
                double d = 2.0*(s -  n * a0) / (n * (n - 1.0));
                double an = a0 + (n - 1.0) * d;
                Console.WriteLine($"D is {d} and An is {an}");
            } else if (n==1)
            {
                Console.WriteLine(a0);
            }
            #endregion
            }
        }
    }
