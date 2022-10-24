using System;

namespace _1st_Lesson
{
    class Program
    {
        // 1
        Console.Write("Enter your weight in kilograms: ");
        double m = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your hight in meters : ");
        double h = Convert.ToDouble(Console.ReadLine());
        if (m < 1 | h < 1) 
        {
            Console.WriteLine("No way");
        }
        else
        {
            int stepen = 2;
            double h2 = Math.Pow(h, stepen);
            double BMI = m / h2;
            double BMI2 = Math.Round(BMI, 2);
            Console.WriteLine("Your BMI is " + BMI2);
        }


        // 2
        Console.Write("Enter your number in the group: ");
        double N = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your age: ");
        double age = Convert.ToDouble(Console.ReadLine());
        if (N < 1 | age < 1)
        {
            Console.WriteLine("No God plz No No Noooo");
        }
        else
        {
            double a = 100 % N;
            double b = 18 - (a / N);
            double grad = 10 * N;
            double P = 4 * ((3.14 * a * b + (a - b)) / (a + b));
            double lenght = P / 360 * grad;
            double lenght2 = Math.Round(lenght, 1);
            Console.WriteLine(lenght2);
        }


        // 3
        Console.Write("Enter your number in group: ");
        double N = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter your date and mounth of birthday like \"ddmm\": ");
        double ddmm = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter how many terms will be in progression: ");
        double n = Convert.ToDouble(Console.ReadLine());
        if (N < 1 | ddmm < 1 | n < 1)
        {
            Console.WriteLine("Go wdnj yourself");
        }
        else
        {
            double S = 10000 + ddmm;
            double a0 = N;
            double d = ((S * 2) / n - 2 * a0) / (n - 1);
            double an = a0 + (n - 1) * d;
            Console.WriteLine($"Step (d) of progression = {d}");
            Console.WriteLine($"The Nth term of an Arithmetic Sequence = {an}");
        }
    }
}