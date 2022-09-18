using System;

namespace GitHub
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task3();
        }
        public static void Task1()
        {
            Console.WriteLine("Height in santimeters: ");
            double height = Convert.ToDouble(Console.ReadLine())/100;//182
            Console.WriteLine("Weight in kilograms: ");
            double weight = Convert.ToDouble(Console.ReadLine());//78
            if (height < 1 or weight <1) 
            {
                Console.WriteLine("Height or weight can't be 0, enter a real one");
                Console.WriteLine("Height in santimeters: ");
                height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Weight in kilograms: ");
                weight = Convert.ToDouble(Console.ReadLine());
            }
            var bmi = weight / (height * height);
            Console.Write($"BMI = {bmi} ");
            if (bmi <= 18.5)
                Console.WriteLine("Bellow the norm");
            if (bmi < 25)
                Console.Write("Normal");
            else if (bmi <= 29)
                Console.Write("Overweight");
            else
                Console.Write("Obese");
        }

        public static void Task2() 
        {
            double a = 100 % 21;
            double b = 17 - (a / 21);
            double grad = 10 * 6;
            double res = (4 * (Math.PI * a * b + Math.Pow((a - b), 2) / (a + b))) / 360 * grad;
            Console.WriteLine(Math.Round(res,3));
        }
        public static void Task3() 
        {
            const int a0 = 21, S = 10812; 
            double n = Convert.ToDouble(Console.ReadLine()); 
            while (n <= 0) 
            { 
            Console.WriteLine("Please enter different n"); 
            n = Convert.ToDouble(Console.ReadLine()); 
            } 
            double an = S / 2 * n - a0; 
            double shag = (an - a0) / n; 
            Console.WriteLine($"nth term is {an} and the step is {shag}"); 
        }
    }
}
