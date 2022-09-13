using System;
using System.Runtime.InteropServices;

class proga
{
    public static void Main(string[] args)
    {
        #region 1st proga

        Console.WriteLine("Eneter your hight in meters");
        double height = Convert.ToDouble(Console.ReadLine());
        while (height <= 0)
        {
            Console.WriteLine("Please enter your height unequal zero");
            height = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("Enter your weight in kg.");
        double weight = Convert.ToDouble(Console.ReadLine());

        double bmi;

        bmi = weight / (height * height);
        if (bmi < 18.5)
        {
            Console.WriteLine($"Ваш BMI: {bmi}, it is below the norm");
        }
        else if (bmi >= 18.5 && bmi <= 25)
        {
            Console.WriteLine($"Ваш BMI: {bmi}, it is normal");
        }
        else
        {
            Console.WriteLine($"Ваш BMI: {bmi}, it is above the norm");
        }

        #endregion


        #region 2nd proga
        const double a = 100 % 27;
        const double b = 20 - a;    //взял возрвст 20, тк возраст - а выходило отрицательное число 
        double grad = 10 * 27;
        grad = Math.PI * grad;

        Console.WriteLine(Math.Sqrt((Math.Pow(a, 2) * Math.Pow(b, 2)) / (Math.Pow(a, 2) * Math.Pow(Math.Sin(grad), 2) + (Math.Pow(b, 2) * Math.Pow(Math.Cos(grad), 2)))));
        #endregion


        #region 3rd proga

        const int a0 = 27, S = 13006;
        double n = Convert.ToDouble(Console.ReadLine());
        while (n <= 0)
        {
            Console.WriteLine("Please enter different n");
            n = Convert.ToDouble(Console.ReadLine());   
        }
        double an = S / 2 * n - a0;
        double shag = (an - a0) / n;
        Console.WriteLine($"nth term is {an} and the step is {shag}");

        #endregion
    }
}
