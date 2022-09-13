using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            double weight = 80;
            double height = 1.7;
            double BMI = 0;
            height = height * height;
            if (height != 0)
            {
                BMI = weight / height;
            }
            Console.WriteLine(BMI);
            #endregion

            #region Task2
            double a = 100 % 15;
            double b = 17 - (a / 15);
            int grad = 10 * 15;
            double p = 3.14 * a * b + (a - b);
            p = (p / a + b) * 4;
            b = grad * p / 360;
            Console.WriteLine($"Tvoya duga blin {b}");
            #endregion

            #region
            int a0 = 15;
            int S = 12302;
            int n = Convert.ToInt32(Console.ReadLine());
            int unkn = 0; 
            if ((n-a0 > 0))
                unkn = 2 * S / n - a0;
            double Shag = 0;
            if ((n*(n-1))>0)
                Shag = (2 * (S - n * a0)) / n * (n - 1);
            Console.WriteLine($"Karoche shag takoy {Shag}");
            Console.WriteLine($"A vot tvoe chislo {unkn}");

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
