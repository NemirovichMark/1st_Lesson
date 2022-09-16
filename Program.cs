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
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task_0.1
            Console.WriteLine("Task 0.1:");
            try
            {
                Console.WriteLine("Insert your weight (kg):");
                double mm = double.Parse(Console.ReadLine());
                while (mm <= 0)
                {
                    Console.WriteLine("ERROR: weight cannot be negative or zero");
                    mm = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Insert your height (cm):");
                double hh = double.Parse(Console.ReadLine());
                while (hh <= 0)
                {
                    Console.WriteLine("ERROR: height cannot be negative or zero");
                    hh = int.Parse(Console.ReadLine());
                }
                    double xx1 = mm / ((hh / 100) * (hh / 100));
                Console.WriteLine($"\nWeight: {mm}\nHeight: {hh}\nBMI: {Math.Round(xx1,2)} \n\n\n");
            }

            catch (Exception e)
            {
                Console.WriteLine($"ERROR: Wrong input \n {e}");
            }


            #endregion
                
                
            #region task_0.2    
            Console.WriteLine("Task 0.2:");
            double aa = 100 % 7;
            double bb = 21 - (aa / 7);
            int grad = 10 * 7;
            double xx2 = Math.PI * (aa + bb) * grad / 360;
            Console.WriteLine($"b = {Math.Round(bb, 2)}\ngrad = {grad}\na = {aa}\n\nThe length of the ellipse sector curve: {Math.Round(xx2, 2)} \n\n\n");
            #endregion
                
                
            #region task 0.3 
            Console.WriteLine("Task_0.3:");
            double aa0 = 7;
            double ss = 12511;
            try
            {
                Console.WriteLine("Insert n:");
                double nn = double.Parse(Console.ReadLine());
                while (nn <= 1)
                {
                    Console.WriteLine("ERROR: n cannot be less then 2 ");
                    nn = int.Parse(Console.ReadLine());
                }
                double nth = ss * 2 / nn - aa0;
                double dd = (nth - aa0) / (nn - 1);
                Console.WriteLine($"\nStep (d) = {Math.Round(dd, 2)}\nnth term of the sequence = {Math.Round(nth, 2)}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR: Wrong input \n {e}");
            }
            #endregion
        }
    }
}
