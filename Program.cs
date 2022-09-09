using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Body mass index
            double weight = 58.2;
            double height = 1.653;
            double bmi = Math.Round(weight / (height * height), 3);

            Console.WriteLine($"My body mass index is: {bmi}");
            #endregion

            #region Ellipse sector curve length
            int numInGroup = 1;
            double a = 100.0 % numInGroup;

            double b = 20.0 - (a / numInGroup);
            double grad = 10 * numInGroup;

            double perimeter = 4 * (Math.PI * a * b + ((a - b) * (a - b))) / (a + b);
            double curveLength = Math.Round(perimeter * grad / 360.0, 3);

            Console.WriteLine($"Ellipse sector curve length is: {curveLength}");
            #endregion

            #region Arithmetic Sequence
            string errorMessage = "\nYou've given a wrong value! Please, restart the program...";

            int a0 = 1;
            int S = 11702;
            int n = 0;

            Console.WriteLine("\nAnd for the third task please specify the count of terms");
            Console.WriteLine("(!) It must be a positive integer!");
            Console.Write("Your value: ");

            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= 0)
                {
                    Console.WriteLine(errorMessage);
                }
                else
                {
                    double d = (2.0 * S - 2.0 * a0 * n) / (n * (n - 1.0));
                    double an = 2.0 * S / n - a0;

                    Console.WriteLine("\nSo the solution is:");
                    Console.WriteLine($"  d = {Math.Round(d, 3)}");
                    Console.WriteLine($"  an = {Math.Round(an, 3)}");
                }
                
            }
            else
            {
                Console.WriteLine(errorMessage);
            }
            #endregion
        }

        /* Tasks:
             * 1. Find your BMI - body mass index
             * 
             * 2. Find the length of the ellipse sector curve with:
             *  a = %(№ in the group)
             *  b = age - (a / № in the group)
             *  grad = 10 * (№ in the group)
             * 
             * 3. Find the step (d) and nth term of an Arithmetic Sequence when:
             *  a0 = (№ in the group)
             *  S = 1ddmm of your birth day
             */
    }
}
