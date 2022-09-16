using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            

            /* Tasks:
             * 1. Find your BMI - body mass index
            */
            int m, h = 62, 175;
            Console.WriteLine( m/(h*h) );
             
             
             /*
             * 2. Find the length of the ellipse sector curve with:
             *  a = 100 % (№ in the group)
             *  b = age - (a / № in the group)
             *  grad = 10 * (№ in the group)
             */
                
             int a = 100 % 23;
             int b = 18 - (a / 23 );
             int grad = 10 * 23;
             Console.WriteLine(Math.PI * (a + b) * Math.Sin(grad));
             
             /* 
             * 3. Find the step (d) and nth term of an Arithmetic Sequence when:
             *  a0 = (№ in the group)
             *  S = 1ddmm of your birth day
             */
            int a0 = 23;
            int S = 11905;
            int n = Console.ReadLine();
            an = (S / n * 2) - a0;
            d = (S / n * 2 - 2 * a0) / (n - 1);
            Console.WriteLine(an);
            Console.WriteLine(d);
            
        }
    }
}