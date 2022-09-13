using System;

namespace _1st_Lesson
{
    class Program
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
            if (height == 0) 
            {
                Console.WriteLine("height can't be 0, enter a real one");
                height = Convert.ToDouble(Console.ReadLine());
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
            int a_0 = 21;
            int S = 10812;
            Console.Write("Enter the amount of members of the arithmetic progression: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double d;
            if (n != 0) 
            {
                double a_n = (S * 2 / n) - a_0;
                d = (a_n - a_0) / n;
                if (a_n < 0) 
                {
                    Console.WriteLine("term of sequence cant be negative, try with another numbers");
                    return;
                }
            }
            else
            {
                Console.Write("Enter another number that is not 0: ");
                n = Convert.ToInt32(Console.ReadLine());
                double a_n = (S * 2 / n) - a_0;
                d = (a_n - a_0) / n;
            }
            Console.WriteLine($"The step of the arithmetic progression: {d}");
        }
    }
}
