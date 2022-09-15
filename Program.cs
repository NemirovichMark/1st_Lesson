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

            #region Task 1
            double height = 1.85;
            double bmi = 0;
            double weight = 70;
            if (height > 0 && weight > 0)
            {
                bmi = weight / Math.Pow(height, 2);
            }
            Console.WriteLine(bmi);
            #endregion
            #region Task2
            int numberInGroup = 14;
            int age = 17;

            double a = 100 % numberInGroup;
            double b = age - a / numberInGroup;
            double angle = (10 * numberInGroup) * Math.PI / 180;

            double Length = Math.PI * (a + b) * Math.Sin(angle);
            Console.WriteLine(Length);
            #endregion
            #region Task 3
            double a0 = 14;
            double s = 11410;
            int n = 0;

            while (n <= 1)
            {
                try
                {
                    Console.Write("Enter n(): ");
                    n = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("you lose");
                }
            }
            double an = ((2 * s) / n) - a0;
            double d = (an - a0) / (n - 1);
            Console.WriteLine($"last: {an}\nstep: {d}");
            #endregion
        }
    }
}
