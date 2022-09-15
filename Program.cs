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
        double BMI;
        BMI = weight / (height * height);
        if (BMI > 0 && BMI <= 18)
        {
            Console.WriteLine($"Your BMI: {BMI} lower than normal");
        }
        else if (BMI >= 18 && BMI <= 25.3)
        {
            Console.WriteLine($"Your BMI: {BMI} is normal");
        }
        else if (BMI <= 0)
        {
            Console.WriteLine("Check your data again, BMI can not be 0 or lower");
        }
        else
        {
            Console.WriteLine($"Your BMI: {BMI} above the normal");
        }
        #endregion

        #region code2
        const double a = 100 % 20; // Выводит 0 из-за того, что использую число 20, но это было ваше задание.
        const double b = 18 - (a / 20);
        double grad = 10 * 20;
        Console.WriteLine(Math.Sqrt((Math.Pow(a, 2) * Math.Pow(b, 2)) / (Math.Pow(a, 2) * Math.Pow(Math.Sin(grad), 2) + (Math.Pow(b, 2) * Math.Pow(Math.Cos(grad), 2)))));
        #endregion

        #region code3
        const int a0 = 20;
        const int S = 10809;
        double n = Convert.ToDouble(Console.ReadLine());
        if (n <= 0)
        {
            Console.WriteLine("This n <= 0, pls use another n");
            n = Convert.ToDouble(Console.ReadLine());
        }
        double an = S / 2 * n - a0;
        double shag = (an - a0) / n;
        Console.WriteLine($"nth term == {an}, step of an Arithmetic Sequence == {shag}");

        #endregion
    }
}
