using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            double weight = 80;
            double height = 1.7;
            double BMI = 0;
            height = height * height;
            BMI = weight / height;
            Console.WriteLine(BMI);
            #endregion

            #region Task2
            double a = 100 % 15;
            double b = 17 - (a / 15);
            int grad = 10 * 15;
            double p = 3.14 * a * b + (a - b);
            p = (p / a + b) * 4;
            b = grad * p / 360;
            Console.WriteLine($"Tvoya duga blin {b}");
            #endregion

            #region
            int a0 = 15;
            int S = 12302;
            int n = Convert.ToInt32(Console.ReadLine());
            int unkn = 2 * S / n - a0;
            double Shag = (2 * (S - n * a0)) / n * (n - 1);
            Console.WriteLine($"Karoche shag takoy {Shag}");
            Console.WriteLine($"A vot tvoe chislo {unkn}");

            #endregion

        }
    }
}
