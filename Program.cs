using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, weight, BMI = 0;

            Console.WriteLine("Введите свой рост в метрах");

            if (Double.TryParse(Console.ReadLine(), out height) && height > 0)

                Console.WriteLine("Введите свой вес");

            if (Double.TryParse(Console.ReadLine(), out weight) && weight > 0)

                BMI = (weight / (height * height));

            Console.WriteLine($"Ваш BMI = {BMI}");

            double a, b, grad, p, l;
            a = 100 % 19;
            b = 18 - (a / 19);
            grad = 10 * 19;
            p = 4 * (Math.PI * a * b + Math.Pow(a - b, 2)) / (a + b);
            l = p * grad / 360.0;
            Console.WriteLine(l);
            int a0 = 19;
            int s = 10101;
            int n;
            Console.WriteLine("n=");
            if (Int32.TryParse(Console.ReadLine(), out n)) ;
            double d = (2.0 * s - 2.0 * a0 * n) / (n * (n - 1.0));
            double an = 2.0 * s / n - a0;
            Console.WriteLine($"шаг прогрессии = {d}  И   An = {an}");


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
        }
    }
}
