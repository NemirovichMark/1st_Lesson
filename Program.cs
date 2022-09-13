using System;

namespace _1st_Lesson
{
    class program
    {
        static void Main(string[] args)
        {
            #region task1
            Console.WriteLine("Task One");
            double a = 1.63;
            int b = 49;
            double bmi;
            if (a != 0)
            {
                bmi = b / (a * a);
                Console.WriteLine(bmi);
            }
            else
            {
                Console.WriteLine("YOU ARE LOZE");
            }    
            
            #endregion

            #region task2
            Console.WriteLine("Task Two");
            int aa = 100 % 15;
            double bb = 18 - (aa / 15);
            double grad = 10 * 15;
            double length;

            grad = Math.PI * grad / 180.0;
            length = Math.Sqrt((Math.Pow(a, 2) * Math.Pow(b, 2)) / (Math.Pow(a, 2) * Math.Pow(Math.Sin(grad), 2) + (Math.Pow(b, 2) * Math.Pow(Math.Cos(grad), 2))));
            Console.WriteLine(length);
            #endregion


            #region task3
            Console.WriteLine("Task Three");
            int n = Convert.ToInt32(Console.ReadLine());
            int a0 = 15;
            int s = 10905;
            double d;
            if ((n != 0) & (n != 1))
            {
                d = (2 * ((s / n) - a0)) / (n - 1);
                double an = a0 + d * (n - 1);
                Console.WriteLine(d);
                Console.WriteLine(an);
            }
            else
            {
                Console.WriteLine("YOU ARE LOZE");
            }
            #endregion
        }
    }
}
