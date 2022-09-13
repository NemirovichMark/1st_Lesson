using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task_1
            double wheight = 47;
            double tall = 164;
            if (tall <= 0)
            {
                Console.WriteLine("invalid value of parameter tall");
            }
            else
            {
                double bmi = (wheight / tall * tall);
                Console.WriteLine(bmi);
            }
            #endregion
            #region Task_2
            int a = 100 % 17;
            int b = 17 - (a / 17);
            int grad = 10 * 17;
            double p = Math.PI * (a + b) * Math.Sin(Math.PI * grad / 180);
            Console.WriteLine(p);
            #endregion
            #region Task_1
            int a0 = 17;
            int S = 12910;
            int n = Convert.ToInt32(Console.ReadLine());
            if (n - a0 <= 0)
            {
                Console.WriteLine("invalid value of parameters");
            }
            else
            {
                double an = 2 * S / n - a0;
                double d = (an - a0) / n;
                Console.WriteLine(d);
                Console.WriteLine(an);
            }
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
