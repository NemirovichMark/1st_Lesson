using System;

namespace Homework
{
    class Programm
    {
        static void Main(string[] args)
        {
            #region 1 
            Console.WriteLine("answer for 1 task");
            double BMI = 73 / (1.75 * 1.75);
            Console.WriteLine($"My BMI is {BMI}");
            #endregion


            #region 2
            Console.WriteLine("answer for 2 task");
            int number = 11;
            double a = 100 % number;
            double b = 18 - (a / number);
            double grad = (Math.PI * (10 * 11))/180;
            double L = Math.Sqrt((Math.Pow(a, 2) * Math.Pow(b, 2)) / (Math.Pow(a, 2) * Math.Pow(Math.Sin(grad), 2) + (Math.Pow(b, 2) * Math.Pow(Math.Cos(grad), 2))));
            Console.WriteLine(L);
            #endregion

            #region 3
            int a0 = 11;
            int S = 10106;
            int n = int.Parse(Console.ReadLine());
            int an = S / n * 2 - a0;
            double d = (an - a0) / n;
            Console.WriteLine("answer for 3 task");
            Console.WriteLine(d);
            #endregion
        }
    }
}
