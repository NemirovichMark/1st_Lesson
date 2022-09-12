using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HomeWork1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex1
            double weight = 70.0;
            double height = 180.0;
            double bmi = (weight / (height * height)) * 10000;
            WriteLine($"Body mass index is {bmi}");
            #endregion

            #region Ex2
            double a = 100 % 4;
            double b = 18 - (a / 4);
            double grad = 10 * 4;
            double perimetr = (4 * (Math.PI * a * b * (a - b)) / (a + b)); //формула нахождения периметра
            double length = perimetr / 360 * grad;
            WriteLine($"the length of the ellipse sector curve is {length}");
            #endregion

            #region Ex3
            double a0 = 4;
            double S = 11907;
            WriteLine("Введите член прогрессии");
            int n = int.Parse(ReadLine());
            double step_d = (2.0 * S - 2.0 * a0 * n) / (n * (n - 1.0));
            double term = 2 * S / n - a0;
            WriteLine($"the step of an Arithmetic Sequence is {step_d} , nth term of an Arithmetic Sequence is {term}"); 
            #endregion
        }
    }
}
