using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Body Mass Index

            double height = 1.79, weight = 62.5;
            double BMI;
            BMI = weight / (Math.Pow(height, 2));
            Console.WriteLine($"My BMI: {BMI}");

            #endregion

            #region Lenght of the Ellipse

            int num = 31;
            int a1 = (100 % num), b1 = 18 - (a1 / num);
            double grad = 10 * num;
            double L, lenght;

            //L = a1 * (2.28 * Math.Pow((b1 / a1), 1.44) + 4);
            //lenght = grad / 360 * L;
            L = 3 * (a1 + b1) / 2 - Math.Sqrt(a * b);
            lenght = grad / 360 * L * Math.PI;
            Console.WriteLine($"Length of the ellipse sector curve is: {lenght}");

            #endregion

            #region Arithemetic Sequence

            int a0 = 31;
            int S = 10308;
            Console.WriteLine("Type the number of elements:");
            if (Int32.TryParse(Console.ReadLine(), out int count))
            {
                int last_element;
                double step;

                last_element = 2 * S / count - a0;
                step = (last_element - a0) / (count - 1);
                Console.WriteLine($"Last element: {last_element}, step: {step}");
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
