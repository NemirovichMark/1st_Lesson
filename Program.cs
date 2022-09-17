using System;
namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region firstTask
            /*
             * 1. Find your BMI - body mass index
             */
            Console.Write("Introduce your height in meters(Use the comma): ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("Introduce your weight in kg's: ");
            double weight = double.Parse(Console.ReadLine());
            if (height != 0 && weight != 0)
            {
                double BMI = Math.Round(weight / (height * height), 2);
                switch (BMI)
                {
                    case double n when (n <= 18.5):
                        Console.WriteLine("Your BMI is: {0}", BMI + " You are underweight");
                        break;
                    case double n when (n >= 18.5 && n <= 24.9):
                        Console.WriteLine("Your BMI is: {0}", BMI + " You are healthy");
                        break;
                    case double n when (n >= 25 && n <= 29.9):
                        Console.WriteLine("Your BMI is: {0}", BMI + " You are overweight");
                        break;
                    case double n when (n >= 30 && n <= 39.9):
                        Console.WriteLine("Your BMI is: {0}", BMI + " You are obese");
                        break;
                    default:
                        Console.WriteLine("Your BMI is: {0}", BMI + " You are extremely obese");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Introduce some real value, please.");
            }
            #endregion

            #region secondTask
            /* 2. Find the length of the ellipse sector curve with:
            *  a = 100 % (№ in the group)
            *  b = age - (a / № in the group)
            *  grad = 10 * (№ in the group)
            */
            double age = 19;
            double a = 100 % 31;
            double b = age - (a / 31);
            double grad = 10 * 31;
            double lenghtEllipseSectorCurve = (4 * ((Math.PI * a * b) + Math.Pow(a - b, 2) / (a + b)) * grad / 360);
            Console.WriteLine("The length of the ellipse sector curve is {0}", lenghtEllipseSectorCurve);
            #endregion

            #region thirdTask
            /* 3. Find the step (d) and nth term of an Arithmetic Sequence when:
            *  a0 = (№ in the group)
            *  S = 1ddmm of your birth day
            */
            Console.Write("Introduce the a0(first nth term) value with your group's number: ");
            double a0 = double.Parse(Console.ReadLine());
            Console.Write("Introduce the s (sum of the arithmethic progression) value birth day(1ddmm): ");
            double s = double.Parse(Console.ReadLine());
            Console.Write("Introduce the nth (nth term) value: ");
            double nth = double.Parse(Console.ReadLine());
            if (nth > 0)
            {
                double d = 2 * (s - nth * a0) / nth * (nth - 1);
                double an = a0 + (nth - 1) * d;
                Console.WriteLine("The value of d is: {0}", d);
                Console.WriteLine("the value of an is: {0}", an);
            }
            else
            {
                Console.WriteLine("The value of nth has to be greater than 0");
            }
            #endregion
        }
    }
}
