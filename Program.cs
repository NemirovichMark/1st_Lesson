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
            
            #region 1st_pr
            Console.WriteLine("Enter your weight:");
            double weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your height:");
            int height = Convert.ToInt32(Console.ReadLine());

            double BIM = Math.Round(weight / Math.Pow(height, 2) * 10000, 1);

            Console.WriteLine($"Your BIM is {BIM}");
            if (BIM < 18.5)
            {
                Console.WriteLine("You have underweight:");
            }
            if (18.5 < BIM & BIM < 25)
            {
                Console.WriteLine("You have normal BIM:");
            }
            if (25 < BIM & BIM < 30)
            {
                Console.WriteLine("You have overweight:");
            }
            if (30 < BIM & BIM < 35)
            {
                Console.WriteLine("You have obesity of the first degree:");
            }
            if (35 < BIM & BIM < 40)
            {
                Console.WriteLine("You have obesity of the second degree:");
            }
            if (BIM > 40)
            {
                Console.WriteLine("You have obesity of the third degree:");
            }
            #endregion

            #region 2nd_pr
            int a = 100 % 26;
            int b = 17 - (a / 26);
            int grad = 10 * 26;
            double perimetr = 4 * (Math.PI * a * b + (a - b)) / (a + b);
            double total = grad * 360 / perimetr;

            Console.WriteLine(total);
            #endregion

            #region 3nd_pr
            int a0 = 26;
            int S = 12901;
            int n = Convert.ToInt32(Console.ReadLine());
            double d = (2 * (S - n * a0)) / n * (n - 1);
            int nth = 2 * S / n - a0;
            Console.WriteLine($"step of Arithmetic Sequence {d}");
            Console.WriteLine($"nth of Arithmetic Sequence {nth}");
            #endregion

        }
    }
}
