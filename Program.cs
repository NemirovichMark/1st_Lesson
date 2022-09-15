using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        
        {
            //goto lab1_task2;
            //goto lab1_task3;
            //(these were made for my own quick testing of the tasks)

            #region lab1_task1
            // I've decided to try making an interactive program for BMI calculaton.
            Console.WriteLine("Task 1");
            double i, h, m;
            Console.WriteLine("What's your height? (in cm)");

        TryHeight:
            string s = Console.ReadLine();
            bool success = double.TryParse(s, out h);
            if (success)
            {
                if (h <= 0)
                {
                    Console.WriteLine("You're taller than THAT. Try again.");
                    goto TryHeight;
                }
                else
                {
                    Console.WriteLine($"Your height is {h} cm.");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Try again.");
                goto TryHeight;
            }

            Console.WriteLine("What's your weight? (in kg)");

        TryWeight:
            s = Console.ReadLine();
            success = double.TryParse(s, out m);
            if (success)
            {
                if (m <= 0)
                {
                    Console.WriteLine("Don't lie to me. Try again.");
                    goto TryWeight;
                }
                else
                {
                    Console.WriteLine($"Your weight is {m} kg.");
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("Try again.");
                goto TryWeight;
            }

            i = 10000 * m / (h * h);
            Console.WriteLine($"Your BMI is around {i} kg/m^2");
            Console.ReadLine();



        #endregion

        lab1_task2:
            #region lab1_task2
            Console.WriteLine("Task 2");
            double a = 100 % 24;
            double b = 18 - (a / 24);
            double grad = 10 * 24;
            double result;

            double P = 4 * ((Math.PI * a * b + (a - b)) / (a + b));
            result = P / 360 * grad;
            Console.WriteLine($"The length of the ellipse sector curve is {result}");
            Console.ReadLine();
        #endregion

        lab1_task3:
            #region lab1_task3
            Console.WriteLine("Task 3");
            Console.WriteLine("Enter the number of the elements (n) of the sequence.");
            double step, n, nth;
            double a0 = 24;
            double S = 10404;

        TryN:
            bool tryn = double.TryParse(Console.ReadLine(), out n);
            if (!tryn)
            {
                Console.WriteLine("Try again.");
                goto TryN;
            }
            else
            {
                if (n < 2)
                {
                    Console.WriteLine("Try again.");
                    goto TryN;
                }
            }
            Console.WriteLine($"The number of the elements is {n}.");
            Console.WriteLine("");

            step = (2 * S) / (n * (n - 1)) - (2 * a0) / (n - 1);
            Console.WriteLine($"The step of the sequence is {step}.");

            nth = a0 + step * (n - 1);
            Console.WriteLine($"The nth term of the sequence is {nth}.");
            Console.ReadLine();
            #endregion

        }
    }
}
