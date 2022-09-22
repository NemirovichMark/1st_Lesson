using System;
using System.Threading.Tasks;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Tasks:
             * 1. Find your BMI - body mass index
             * 
             * 2. Find the length of the ellipse sector curve with:
             *  a = 100 % (№ in the group)
             *  b = age - (a / № in the group)
             *  grad = 10 * (№ in the group)
             * 
             * 3. Найдите шаг (d) и n-й член арифметической последовательности, когда:
             *  a0 = 11
             *  S = 11502
             */

            //Task 1
            double weight = 55.8;
            double height = 1.7;
            if (weight == 0 && height == 0)
            {
                Console.WriteLine("ВЫ ВВЕЛИ 0");

            }
            else
            {
                double BMI = weight / (height * height);
                Console.WriteLine(BMI);
            }
            //Task 2
            int a = 100 % 11;
            int b = 18 - (a % 11);
            double grad = 10 * 11;
            double p = 3.1415;
            double sec = (grad * 1) / 360;
            if (sec == 0)
            {
            Console.WriteLine("на ноль делить нельзя");
            }
            else
            {
            double P = 2 * p * Math.Sqrt((a*a + b*b) / 2) / sec;
            Console.WriteLine(P);
            }
            //Task 3
            //a0==11,S==11502
            int a0 = 11;
            int S = 11502;
            Console.WriteLine("Введите номер последнего члена n");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <=1 )
            {
            Console.WriteLine("Введите целое положительное число больше 0");
            }
            else
            { 
           
            double an = 2 * S / n - a0;
            double d =(an - a0) / (n - 1);
            Console.WriteLine($"Последний член an {n}: " + an);
            Console.WriteLine("Разность прогрессии: " + d);
            }
            
            
            {
            Console.ReadLine();
            }
        }
    }
}