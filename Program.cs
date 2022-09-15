using System;
using System.Configuration;

namespace SE.task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task #1
            double height = 1.64;
            double weight = 47.5;
            double indexbli = 0.0;
            if ((height > 0 && height < 3 && weight > 0 && weight < 650))
            {
                indexbli = weight / (height * height);
                indexbli = Math.Round(indexbli, 2);
                Console.WriteLine(indexbli);
            }
            else
            {
                Console.WriteLine("Error ");
            }
            if (indexbli < 18.5)
            {
                Console.WriteLine($"Your BMI is: {indexbli} - underweight");
            }
            else
            if (indexbli < 25)
            {
                Console.WriteLine($"Your BMI is: {indexbli} - normal weight");
            }
            else
            if (indexbli < 30)
            {
                Console.WriteLine($"Your BMI is: {indexbli} - overweight");
            }
            else
            if (indexbli >= 30)
            {
                Console.WriteLine($"Your BMI is: {indexbli} - obesity");
            }
            #endregion
            #region Task#2
            double a = 100 % 25;
            double b = 18.0 - (a / 25.0);
            double grad = 10 * 25;
            grad = Math.PI * grad / 180.0;
            double d;
            d = Math.Sqrt((Math.Pow(a, 2) * Math.Pow(b, 2)) / (Math.Pow(a, 2) * Math.Pow(Math.Sin(grad), 2) + (Math.Pow(b, 2) * Math.Pow(Math.Cos(grad), 2))));
            Console.WriteLine($"the length of the ellipse sector curve is {d}");
            #endregion
            #region Task#3
            int a0 = 25;
            int S = 10206;
            int n = Int32.Parse(Console.ReadLine());
            if (n <= 1)
            {
                Console.WriteLine("Error");
                return;
            }
            double d1= (2 * ((S / n) - a0)) / (n - 1);
            double an = a0 + d1 * (n - 1);
            Console.WriteLine($"The last element: {d1} and step: {an}");
            #endregion
        }
    }
}


