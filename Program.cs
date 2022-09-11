using System;
using System.Net.NetworkInformation;

namespace hometask
{
    class Program
    {
        static void Main(string[] args)
        
        {
            #region task1
            int weight;
            double BMI, height;
            weight = 70;
            height = 1.82;
            BMI = weight / (Math.Pow(2, height));
            Console.WriteLine($"BMI - {BMI}");
            #endregion task1
            #region task2
            double a = 100 % 18;
            double b = 18 - (a / 18);
            double grad = 10 * 18;
            const double pi = 3.14;
            double L = 4 * (pi * a * b + Math.Pow(2, a - b)) / (a + b);
            double length = L / 360 * grad;
            Console.WriteLine($"length - {length}");
            #endregion
            #region task 3
            double a0 = 18.0;
            double S = 12104.0;
            string vvod= Console.ReadLine();
            double amount = Convert.ToInt32(vvod);
            double last_element = (S / amount) * 2.0 - a0;
            double step = (last_element - a0) / (amount - 1.0);
            Console.WriteLine($"last_element - {last_element}, step - {step}") ;
            #endregion
        }

    }
}
