using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            Console.WriteLine("Enter your height in cm");
            double height = Convert.ToInt32(Console.ReadLine());
            height = height / 100;
            Console.WriteLine("Enter your weight");
            double weight = Convert.ToInt32(Console.ReadLine());
            double BMI = weight / (height * height);
            Console.WriteLine("Your BMI is {0}", BMI);
            #endregion

            #region task 2
            double a = 100 % 13;
            double b = 18 - a;
            int grad = 10 * 13;
            double p = 4 * ((3.14 * a * b + (a - b)) / (a + b));
            double lenght = p / 360 * grad;
            Console.WriteLine(lenght);
            #endregion

            #region task 3
            const int a0 = 13;
            const int sum = 12011;
            Console.WriteLine("Введите номер члена прогрессии");
            int n = int.Parse(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine("Error, try again");
            }
            else
            {
                int an = sum / n * 2 - a0;
                double D = (2.0 * sum - 2.0 * a0 * n) / (n * (n - 1.0));
                Console.WriteLine(D.ToString());
                Console.WriteLine(an.ToString());
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
