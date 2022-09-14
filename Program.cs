using System;

namespace Lab_0
{
    class Program
    {
        static void Main(string[] args) 
        {
            #region Task_1
            int mass = 65;
            double hight = 1.8;
            if (hight <= 0)
            {
                Console.WriteLine("Incorrect hight");
                return;
            }
            int BMI = Convert.ToInt32(mass / (hight * hight));
            Console.WriteLine($"Task 1 \nYour BMI body mass index: {BMI}");
            #endregion 

            #region Task_2
            double a = 100 % 14;
            double b = 18.0 - (a / 14.0);
            int grad = 10 * 14;
            double P = 4 * ((Math.PI * a * b + (a - b)) / (a + b));
            double length = P / 360 * grad;
            Console.WriteLine($"Task 2 \nLength of the ellipse sector curve: {length}");
            #endregion 

            #region Task_3
            double a0 = 14;
            double S = 11103;
            Console.WriteLine("Task 3");
            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Input is't correct!");
                return;
            }
            if (n <= 1)
            {
                Console.WriteLine("Input is't correct!");
                return;
            }
            double an = (S / n) * 2 - a0;
            double step = (an - a0) / (n - 1);
            Console.WriteLine($"Last element: {an} \nStep of an Arithmetic Sequence: {step}");
            #endregion
        }
    }
}
