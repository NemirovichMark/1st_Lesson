using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
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
            if (n > 0)
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
