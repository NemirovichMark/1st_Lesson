using System;

namespace _1st
{
    internal class Program
    {
        static void Main()
        {
            #region task 1
            Console.WriteLine("Введите ваш рост в сантиметрах/enter your height in cm");
            decimal rost = Decimal.Parse(Console.ReadLine());
            rost = rost / 100;
            Console.WriteLine("Введите ваш вес в килограммах/enter your weight in kg");
            decimal ves = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ваш Индекс массы тела/your body mass index");
            decimal imt = ves / (rost * rost);
            Console.WriteLine(imt.ToString("N5"));
            #endregion
      
            #region task 2
            
            Console.WriteLine("Введите ваш номер в группе");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш возраст/enter your age");
            double age = int.Parse(Console.ReadLine());
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
            Console.WriteLine("Введите интересующий член прогрессии ");
            long n = int.Parse(Console.ReadLine());
            long aN = sum / n * 2 - a0;
            double shagprogressi_D = (2.0 *sum - 2.0 * a0 * n) / (n * (n - 1.0));
            Console.WriteLine(shagprogressi_D.ToString());
            Console.WriteLine(aN.ToString());
            #endregion
        }
    }
}
