using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Tasks:
             * 1. Find your BMI - body mass index
             * 
             * 2. Find the length of the ellipse sector curve with:
             *  a = 100 % (№ in the group)
             *  b = age - (a / № in the group)
             *  grad = 10 * (№ in the group)
             * 
             * 3. Find the step (d) and nth term of an Arithmetic Sequence when:
             *  a0 = (№ in the group)
             *  S = 1ddmm of your birth day
             */
            #region 1
            double bmi = (55 / (1.82 * 1.82));
            Console.WriteLine($"bmi{bmi}");
            #endregion

            #region 2
            double a = (100 % 25)*(100 % 25);
            double b = (18 - (a / 25))*(18 - (a / 25));
            double grad = 10 * 25;
            double sin = Math.Pow(Math.Sin(grad) * (180 / Math.PI), 2);
            double cos = Math.Pow(Math.Cos(grad) * (180 / Math.PI), 2);
            double answer = Math.Sqrt(b * cos + a * sin);
            Console.WriteLine($"Lengh {answer}");

            #endregion 

            #region 3
            int n;
            int a1 = 25;
            Console.WriteLine("n");
            if (Int32.TryParse(Console.ReadLine(), out n) && n > 1)
            {
                int s = 10302;
                double d = 2.0 * (s - n * a1) / (n * (n - 1.0));
                double an = a1 + (n - 1.0) * d;
                Console.WriteLine($"d {d} a-n {an}");
            }
            else if (n == 1)
            {
                Console.WriteLine(a1);
            }
            #endregion
        }
    }
}
