using System;

namespace HomeWork {

    class Program {
        static void Main() {
            #region task 1
            Console.WriteLine("We are find your BMI");
            Console.WriteLine("enter your weight(kg): ");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("enter your heigh(m): ");
            float height = float.Parse(Console.ReadLine());
            double BMI = weight / Math.Pow(height, 2);
            Console.WriteLine("your BMI: {0}", BMI);
            #endregion task 1

            #region task 2
            double a = 100 % 6;
            double b = 18 - (a / 6);
            int grad = 10 * 6;
            double calc = 4 * (Math.PI * a * b + (a - b) * (a - b)) / (a - b);
            double result = calc / 360 * grad;
            Console.WriteLine("Answer is: {0}", result);
            #endregion task 2

            #region task 3
            int a0= 6;
            int s = 10429;
            int n = Int32.Parse(Console.ReadLine());
            int step1 = s / n * 2 - a0;
            double step2 = (step1 - a0) / n;
            Console.WriteLine(step2);
            #endregion task3





        }

    }


}
