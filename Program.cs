using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region 1st_pr
            Console.WriteLine("Enter your weight:");
            double weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your height:");
            int height = Convert.ToInt32(Console.ReadLine());
            if (weight != 0 & height != 0)
            {
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
            }
            else
            {
                Console.WriteLine("Please, enter values not null");
            }
            #endregion

            #region 2nd_pr
            int a = 100 % 26;
            int b = 17 - (a / 26);
            int grad = 10 * 26;
            if (a != 0 & b != 0)
            {
                double perimetr = 4 * (Math.PI * a * b + (a - b)) / (a + b);
                double total = grad * 360 / perimetr;

                Console.WriteLine(total);
            }
            else
            {
                Console.WriteLine("Please, enter values (a nd b) not null");
            }
            #endregion

            #region 3nd_pr
            int a0 = 26;
            int S = 12901;
            int n = Convert.ToInt32(Console.ReadLine());
            if (a0 != 0 & n != 0)
            {
                double d = (2 * (S - n * a0)) / n * (n - 1);
                int nth = 2 * S / n - a0;
                Console.WriteLine($"step of Arithmetic Sequence {d}");
                Console.WriteLine($"nth of Arithmetic Sequence {nth}");
            }
            else
            {
                Console.WriteLine("Please, enter values (a0 and n) not null");
            }
            #endregion

        }
    }
}
