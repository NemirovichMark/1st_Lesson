using System;

namespace _1st_Lesson {
    class Program {
        static void Main(string[] args) {
            #region Task 1

            double weight = 55;
            double height = 1.75;
            double bmi = Math.Round(weight / Math.Pow(height, 2), 2);
            Console.WriteLine($"Task 1\nBMI: {bmi}\n");

            #endregion

            #region Task 2

            int a = 100 % 11;
            double b = 17 - (a / 11);
            double grad = 10 * 11;
            double l = Math.PI * (a + b) * Math.Sin(Math.PI * grad / 180);
            Console.WriteLine($"Task 2\nLength of the ellipse sector curve: {l}\n");

            #endregion

            #region Task 3

            start:
            Console.WriteLine("Task 3");
            double a0 = 11;
            double S = 12512;
            Console.Write("Enter value (n): ");

            try {
                double n = Convert.ToInt32(Console.ReadLine());

                if (n > 1) {
                    double d = ((2 * S) - (2 * a0 * n)) / ((n - 1) * n);
                    double an = a0 + d * (n - 1);
                    Console.WriteLine($"d = {Math.Round(d, 2)}\ta(n) = {Math.Round(an, 2)}");
                }

                else if (n == 1) {
                    Console.WriteLine($"d = {1}\ta(n) = {a0}");
                }
                
                else {
                    Console.WriteLine("--------------------\nEnter the correct value!\n--------------------\n");
                    goto start;
                }
            }
            
            catch {
                Console.WriteLine("--------------------\nEnter the correct value!\n--------------------\n");
                goto start;
            }

            #endregion

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
