using System;

namespace FirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task_1
            Console.WriteLine("Task 1:");
            try
            {
                Console.WriteLine("Insert your weight (kg):");
                double mm = double.Parse(Console.ReadLine());
                while (mm <= 0)
                {
                    Console.WriteLine("weight cannot be negative or zero");
                    mm = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Insert your height (cm):");
                double hh = double.Parse(Console.ReadLine());
                while (hh <= 0)
                {
                    Console.WriteLine("height cannot be negative or zero");
                    hh = int.Parse(Console.ReadLine());
                }
                double xx1 = mm / ((hh / 100) * (hh / 100));
                Console.WriteLine($"\nWeight: {mm}\nHeight: {hh}\nBMI: {Math.Round(xx1, 2)} \n\n\n");
            }

            catch (Exception e)
            {
                Console.WriteLine($"Wrong input \n {e}");
            }

            #endregion

            #region task_2    
            Console.WriteLine("Task 2:");
            double aa = 100 % 9;
            double bb = 18 - (aa / 9);
            int grad = 10 * 9;
            double xx2 = Math.PI * (aa + bb) * grad / 360;
            Console.WriteLine($"b = {Math.Round(bb, 2)}\ngrad = {grad}\na = {aa}\n\nThe length of the ellipse sector curve: {Math.Round(xx2, 2)} \n\n\n");
            #endregion

            #region task 3 
            Console.WriteLine("Task_3:");
            double frs_e = 9;
            double ss = 11008;
            try
            {
                Console.WriteLine("Insert n:");
                double nn = double.Parse(Console.ReadLine());
                while (nn <= 1)
                {
                    Console.WriteLine("n cannot be less then 2 ");
                    nn = int.Parse(Console.ReadLine());
                }
                double nth = ss * 2 / nn - frs_e;
                double dd = (nth - frs_e) / (nn - 1);
                Console.WriteLine($"\nStep (d) = {Math.Round(dd, 2)}\nnth term of the sequence = {Math.Round(nth, 2)}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Wrong input \n {e}");
            }
            #endregion
        }
    }
}