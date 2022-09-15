using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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

            #region First Task
            const double height = 1.58;
            const double weight = 47;
            double BMI;
            BMI = weight / (height * height);
            Console.WriteLine(BMI);
            #endregion

            #region Second Task
            const double a = 100 % 6;
            const double b = 19 - (a / 6);
            const int grad = 10 * 6;
            double result_All, result;
            result_All = 4 * (Math.PI * a * b + (a - b) * (a - b)) / (a + b);
            result = result_All / 360 * grad;

            Console.WriteLine(result);

            #endregion

            #region Third task
            const int a0 = 6;
            const int s = 10508;
            int n = Int32.Parse(Console.ReadLine());
            if (n != 3)
            {
                int a_n = s / n * 2 - a0;
                double Step_b = (a_n - a0) / n;
                Console.WriteLine(Step_b);
            }
            else Console.WriteLine("Error");
            #endregion
        }
    }
}
