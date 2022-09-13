using System;

namespace Homework12_sep
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

                double weight, long_;
                Console.WriteLine("Введите вес:");
                weight = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите рост:");
                long_ = Convert.ToDouble(Console.ReadLine()) * 0.01;
                double BIM = weight / Math.Pow(long_, 2);
                BIM = Math.Round(BIM, 2);
                Console.WriteLine("Индекс тела: " + BIM);

            #endregion

            #region Task 2

                int a = 100 % 9;
                int b = 18 - (a / 9);
                int grad = 10 * 9;
                double perimeter = 2 * Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)) / 2) * Math.PI;
                double lenght = grad * perimeter / 360;
                Console.WriteLine("Длинна сектора: " + Math.Round(lenght, 2));

            #endregion

            #region Task 3

                int S = 11804;
                int a0 = 9;
                Console.WriteLine("Введите номер члена прогрессии:");
                int n = Convert.ToInt32(Console.ReadLine());

                if n != 0:{
                    double aN = 2 * S / n - a0;
                }

                double d = (aN - a0) / (n - 1);
                Console.WriteLine("Член прогрессии: " + aN);
                Console.WriteLine("Шаг прогрессии: " + d);

            #endregion

        }
    }
}
