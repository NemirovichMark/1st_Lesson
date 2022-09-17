using System;

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


            #region Task 1
            int weight = 80;
            double height = 1.88;
            double BMI = weight / (height * height);
            Console.WriteLine($"My BMI is {BMI}");
            #endregion
            #region Task 2
            int age = 18;
            int number = 25;
            int a = 100 % number;
            double b = age - (a / number);
            double grad = 10 * number;
            double pi = 3.141592653589793;
            Console.WriteLine($"The length of the ellipse sector curve = {(a + b) * pi * (grad / 360)}");
            #endregion
            #region Task3
            int S = 1406;
            int a1 = 25;
            Console.WriteLine("Enter the member number of the progression");
            int n = Convert.ToInt32(Console.ReadLine());
            double an = 2 * S / n - a1;
            double d = (an - a1) / (n - 1);
            Console.WriteLine("Member of the progression: " + an);
            Console.WriteLine("Step of the progression: " + d);
            #endregion 






        }




    }
}
 





            
