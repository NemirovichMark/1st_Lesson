using System;

namespace _1st_Lesson
{
class Program
{
static void Main(string[] args)
{
#region 1st

        double a, b, c;
    marker:
        try
        {
            Console.WriteLine("Enter your weight (KG)");
            a = Convert.ToDouble(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Wrong number");
                goto marker;
            }
        }
        catch
        {
            Console.WriteLine("Use numbers, not letters");
            goto marker;
        }
    marker2:
        try
        {
            Console.WriteLine("Enter your height (M)");
            b = Convert.ToDouble(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Wrong number");
                goto marker2;
            }
        }
        catch
        {
            Console.WriteLine("Use numbers, not letters");
            goto marker2;
        }
        c = a / (b * b);
        Console.WriteLine($"{c}");

        #endregion


        #region 2nd

        a = 100 % 15;
        b = 17 - (a / 15);
        double grad = 10.0 * 15.0;
        c = 4 * (Math.PI * a * b + ((a - b) * (a - b) / (a + b)));
        Console.WriteLine($"{c * grad / 360.0}");


        #endregion


        #region 3rd

        double a0 = 15;
        double s = 11112;
        double n = 0.0, z;
        while (n <= 1)
        {
            Console.WriteLine("Enter 'n'");
            n = Convert.ToDouble(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("Error, n's value got to be > 1");
            }
        }
        z = (2 * (s - a0 * n)) / (n * (n - 1));
        Console.WriteLine($"Step equals {z}");
        Console.WriteLine($"n'th term equals {a0 + z * (n-1)}");

        #endregion
    }
}
}