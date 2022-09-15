using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1 
            {
                double height = 1.84;
                double weight = 62;
                double BMI = (weight / Math.Pow(height, 2));
                Console.WriteLine(BMI);
            }
            #endregion
            #region Task2
            {
                int a = 100 % 10;
                int b = 18 - (a / 10);
                int grad = 10 * 10;
                double lp = Math.PI * (a + b) * Math.Sin(Math.PI * grad / 180);
                Console.WriteLine(lp);
                #endregion
                #region Task3
                int a0 = 10;
                int S = 11501;
                int n = Convert.ToInt32(Console.ReadLine());
                double ad = 2 * S / n - a0;
                double d = (ad - a0) / n;
                Console.WriteLine(d);
                Console.WriteLine(ad);
                #endregion



            }

        }
    }
}
