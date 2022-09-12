using System;

namespace _1st
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1

            double BMI = (71 / (1.75 * 1.75));
            Console.WriteLine($"My BMI is {BMI}");

            #endregion

            #region Task 2

            double a = 100 % 11;
            double b = 19 - (a / 11);
            int grad = 10 * 11;
            const double pi = 3.14;
            double AllLength, result;
            AllLength = 4 * ((pi * a * b) + Math.Pow(a - b, 2)) / (a + b);
            result = AllLength / 360 * grad;

            Console.WriteLine($"The length is {result}");

            #endregion

            #region Task 3

            int a0 = 11;
            int S = 5052004;
            Console.WriteLine("Enter the number of members of the progression:");
            if (Int32.TryParse(Console.ReadLine(), out int n))
            {
                if (n >= 1)
                {
                    double an;
                    double d;
                    an = (2 * S / n) - a0;
                    d = (an - a0) / (n - 1);

                    Console.WriteLine($"Step is {d} and nth term is {an}");
                }
                else Console.WriteLine("This can't be"); 
                }

            #endregion
        }
    }
}