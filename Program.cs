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
             * 3. Find the step (d) and nth term of an Arithmetic Sequence when:
             *  a0 = (№ in the group)
             *  S = 1ddmm of your birth day
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
            //a0==11,S==11502,d==?,an==?
            int a0 = 11;
            int S = 11502;
            int n = 2 * S / S + a0;
            int d = 2 * (S - n * a0) / n * (n - 1);
            Console.WriteLine("Введите номер члена последовательности(от 2)");
            int an = Convert.ToInt32(Console.ReadLine());
            if (an <= 0)
            {
            Console.WriteLine("Вы ввели не допустимое значение");
            }
            else
            {
            int last = a0 + (an - 1) * d;
            Console.WriteLine($"{an} член прогрессии равен {last},разность арифметической прогрессии равна {d}");
            }
            { 
            Console.ReadLine();
            }


















        }
    }
}
