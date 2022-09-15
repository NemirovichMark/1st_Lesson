using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

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
            //double weight = 0;
            //double height = 0;
            //while (weight <= 0 && height <= 0)
            //{
            //    try
            //    {
            //        Console.Write("Enter your weight(kg): ");
            //        weight = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //        Console.Write("Enter your height(m): ");
            //        height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Error...try again");
            //    }

            //}

            //double bmi = weight / Math.Pow(height, 2);
            //Console.WriteLine($"Your bmi: {Math.Round(bmi, 1)}");






            #endregion

            #region Task 2

            //int numberInGroup = 6;
            //int age = 18;

            //double a = 100 % numberInGroup;
            //double b = age - a / numberInGroup;
            //double grad = (10 * numberInGroup) * Math.PI / 180;

            //double LengthOfEllipseCurve = Math.PI * (a + b) * Math.Sin(grad);
            //Console.WriteLine($"Length of ellipse curve: {Math.Round(LengthOfEllipseCurve, 3)}");
            #endregion

            #region Task 3
            //double a0 = 6;
            //double s = 10708;
            //int n = 0;

            //while (n <= 1)
            //{
            //    try
            //    {
            //        Console.Write("Enter n(minimum 2): ");
            //        n = Int32.Parse(Console.ReadLine());
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Oops...Wrong input");
            //    }
            //}
            //double a_nth = ((2 * s) / n) - a0;
            //double step = (a_nth - a0) / (n - 1);
            //Console.WriteLine($"Nth Term: {a_nth}\nStep: {step}");

            #endregion
        }
    }
}
