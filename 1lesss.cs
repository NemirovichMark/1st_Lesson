using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1 
            {
                double height = 1.84;
                double weight = 62;
                double BMI = (weight / Math.Pow(height, 2));
                Console.WriteLine(BMI);
            }
            #endregion
            #region Task2
            {
                int a = 100 % 10;
                int b = 18 - (a / 10);
                int grad = 10 * 10;
                double lp = Math.PI * (a + b) * Math.Sin(Math.PI * grad / 180);
                Console.WriteLine(lp);
                #endregion
                #region Task3
                Console.WriteLine("Моя дата рождения - 15.01.2004");
                int S = 11501;
                Console.WriteLine("Мой номер в группе - 10");
                int a0 = 10;
                Console.WriteLine("Введите количество членов арифмитической последовательности");
                int n = Int32.Parse(Console.ReadLine());
                if (n > 0)
                {
                    double an = (2 * S) / n - a0;
                    double d = (an - a0);
                    Console.WriteLine("Разница между двумя членами последовательности равняется " + d + "!");
                }
                else
                {
                    Console.WriteLine("Иди учить математику! ");
                }
                Console.ReadLine();
                #endregion
              

                    
            }

        }
    }
}
