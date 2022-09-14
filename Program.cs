using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 0.1

            const double weight = 65;
            const double height = 1.76;
            double BMI = weight / Math.Pow(height, 2);
            Console.WriteLine($"BMI = {BMI}");


            #endregion


            #region task 0.2

            const double a = 100 % 4;
            const double b = 17 - (a / 4);
            const double grad = 10 * 4;
            double whole_length = 4 * (Math.PI * a * b + Math.Pow((a - b), 2)) / (a + b);
            double length = whole_length / 360 * grad;
            Console.WriteLine($"length = {length}");


            #endregion


            #region task 0.3

            const double aO = 4;
            const double S = 11111.0;
            double n;
            double.TryParse(Console.ReadLine(), out n);
            double nth = S * 2 / n - aO;
            double d = (nth - aO) / (n - 1);
            Console.WriteLine($"nth elem = {nth}");
            Console.WriteLine($"d = {d}");

            #endregion

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
        }
    }
}