using System;

namespace _1st
{
    internal class Program
    {
        static void Main()
        {
            #region task 1
            double height;
            double weight;
            Console.WriteLine("Введите ваш рост в метрах");
            if (Double.TryParse(Console.ReadLine(), out height) && height > 0)
            {
                Console.WriteLine("Введите ваш вес в килограммах/enter your weight in kg");
                if (Double.TryParse(Console.ReadLine(), out weight) && weight > 0)
                {
                    Console.WriteLine("Ваш Индекс массы тела/your body mass index");
                    Console.WriteLine(weight / (height * height));
                }
            }
            #endregion

            #region task 2
            const int num = 7;
            const int  age = 18;
            double a = 100 % num;
            double b = age - (a / num);
            int grad = 10 * num;
            double perimetr = 4 * (((Math.PI * a * b + Math.Pow(a - b, 2)) / (a + b)));
            double otvet = ((double)grad * perimetr) / 360;
            Console.WriteLine(otvet.ToString("N5"));
            #endregion

            #region task 3
            const long a0 = 7;
            const long sum = 11706;
            int n;
            Console.WriteLine("Введите интересующий член прогрессии");
            if (Int32.TryParse(Console.ReadLine(), out n));
            double aN = 2.0 * sum / n - a0;
            double shagprogressi_D = (2.0 * sum - 2.0 * a0 * n) / (n * (n - 1.0));
            Console.WriteLine($"d = {shagprogressi_D}, aN = {aN}");
            #endregion
        }
    }
}
