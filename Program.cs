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
             *  a = %(№ in the group)
             *  b = age - (a / № in the group)
             *  grad = 10 * (№ in the group)
             * 
             * 3. Find the step (d) and nth term of an Arithmetic Sequence when:
             *  a0 = (№ in the group)
             *  S = 1ddmm of your birth day
             */

            #region 1
            double bmi = (70 / (Math.Pow(1.8,2)));
            Console.WriteLine($"My BMI is {bmi}");
            #endregion

            #region 2
            // i dont know my number in the group, so let it be 7
            double a = Math.Pow(100%7,2);
            double b = Math.Pow(18 - (a / 7),2);
            double grad = Math.Atan((a/b)*Math.Tan(10 * 7));
            double sin = Math.Pow(Math.Sin(grad),2);
            double cos = Math.Pow(Math.Cos(grad),2);
            double answer = Math.Sqrt(a * sin + b * cos);
            Console.WriteLine($"Length is {answer}");

            #endregion 

            #region 3
            int a0 = 7;
            int s = 131310303;
            int n;
            Console.WriteLine("Type the n");
            if (Int32.TryParse(Console.ReadLine(), out n))
            {
                // i dont know how to solve this question. There are no any formulas if S is the complete sum of sequence
            }
            #endregion
        }
    }
}
