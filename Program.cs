using System;
class Programlab1
{
    public static void Main(string[] args)
    {
        #region code1

        Console.WriteLine("Enter your weight (kg)");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter your height (meters)");
        double height = Convert.ToDouble(Console.ReadLine());
        while (height <= 0)
        {
            Console.WriteLine("Check your data again, your height can not be 0 or lower");
            height = Convert.ToDouble(Console.ReadLine());
        }
        double BMI;
        BMI = weight / (height * height);
        Console.WriteLine($"Your BMI: {BMI}");
        #endregion

        #region code2
        const double a = 100 % 20; // Выводит 0 из-за того, что использую число 20, но это было ваше задание.
        const double b = 18 - (a / 20);
        double grad = 10 * 20;
        Console.WriteLine(Math.Sqrt((Math.Pow(a, 2) * Math.Pow(b, 2)) / (Math.Pow(a, 2) * Math.Pow(Math.Sin(grad), 2) + (Math.Pow(b, 2) * Math.Pow(Math.Cos(grad), 2)))));
        #endregion

        #region code3
        const int a0 = 20, S = 10809;
        int n = Convert.ToInt32(Console.ReadLine());
        double step = (2 * (S - n * a0)) / n * (n - 1);
        double nth = 2 * S / n - a0;
        Console.WriteLine($"The step of an Arithmetic Sequence = {step}, and Nth term of an Arithmetic Sequence = {nth}");
        #endregion
    }
}
