using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            double weight = 58.0, height = 1.65
            if (height <= 0)
            {
                Console.WriteLine("imposible");
            }
            else
            {
                double BMI = (weight / height * height);
                Console.WriteLine(BMI);
            }

            #endregion

            #region Task2

            int a = 100 % 18;
            int b = 18 - (a / 18);
            int grad = 10 * 18;
            double p = Math.PI * (a + b) * Math.Sin(Math.PI * grad / 180);
            Console.WriteLine(p);

            #endregion

            #region Task3

            int a0 = 18;
            int S = 12408;
            //          в процессе, вернется в скором времени

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