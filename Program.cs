using System;
using System.Runtime.InteropServices;

class proga
{
    public static void Main(string[] args)
    {
        #region 1st

        Console.WriteLine("Eneter your hight (meters)");
        double height = Convert.ToDouble(Console.ReadLine());
        while (height <= 0)
        {
            Console.WriteLine("error, please enter value > 0");
            height = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Enter your weight in kg.");
        double weight = Convert.ToDouble(Console.ReadLine());

        double bmi;

        bmi = weight / (height * height);
        Console.WriteLine("your BMI: {0}", bmi);
      

        #endregion


        #region 2nd 
        const double a = 100 % 6;
        const double b = 18 - a; 
        double grad = 10 * 27;
        grad = Math.PI * grad;

        Console.WriteLine(Math.Sqrt((Math.Pow(a, 2) * Math.Pow(b, 2)) / (Math.Pow(a, 2) * Math.Pow(Math.Sin(grad), 2) + (Math.Pow(b, 2) * Math.Pow(Math.Cos(grad), 2)))));
        #endregion


        #region 3rd proga

        const int a0 = 6, S = 12904;
        double n = Convert.ToDouble(Console.ReadLine());
        while (n <= 0)
        {
            Console.WriteLine("Please enter different n");
            n = Convert.ToDouble(Console.ReadLine());
        }
        double an = S / 2 * n - a0;
        double step = (an - a0) / n;
        Console.WriteLine($"nth term is {an} and the step is {step}");

        #endregion
    }
}
