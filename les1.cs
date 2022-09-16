using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1

            double weight = 58.0, height = 1.65;
            if (height > 0)
            {
                double BMI = (weight / height * height);
                Console.WriteLine(weight / height * height);
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
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                double Aq = 2 * S / n - a0;
                double d = (Aq - a0) / n;
                Console.WriteLine(d);
                Console.WriteLine(Aq);

            }
            else
            {
                Console.WriteLine("Incorrect (n)");
            }

            #endregion
            /* Tasks:
             * 1. Find your BMI - body mass index
             * 
             * 2. Find the length of the ellipse sector curve with:
             *  a = 100 % (¹ in the group)
             *  b = age - (a / ¹ in the group)
             *  grad = 10 * (¹ in the group)
             * 
             * 3. Find the step (d) and nth term of an Arithmetic Sequence when:
             *  a0 = (¹ in the group)
             *  S = 1ddmm of your birth day
             */
        }
    }
}
