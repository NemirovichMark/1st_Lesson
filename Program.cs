using System;
using System.Globalization;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
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
            #region Task_1
            double weigth = 0;
            double heigth = 0;
            
            while (weigth <= 0 && heigth <= 0)
            {
                try
                {
                    Console.Write("Input weigth in kg : ");
                    weigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Input heigth in meters : ");
                    heigth = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input. Try again");
                }
            }

            double BMI = weigth / Math.Pow(heigth, 2);
            Console.WriteLine($"BMI = {Math.Round(BMI, 4)}");
            #endregion

            #region Task_2
            int numberInGroup = 9;
            double a = 100 % numberInGroup;
            double b = 20 - (a / numberInGroup);
            double grad = 10 * numberInGroup;

            double lengthSectorCurve = Math.PI * (a + b) * Math.Sin(grad);
            Console.WriteLine($"length of the Ellipse sector curve : {lengthSectorCurve}");

            #endregion

            #region Task_3
            double firstElement = numberInGroup;
            double nElement;
            double sum = 10908;
            int numberElements = -1;
            double difference;
            Console.WriteLine($"first element: {firstElement}, sum : {sum}");
            Console.WriteLine($"Number of elements(>= 0) for 1, it turns out that {firstElement} == {sum}\nthe meaning is lost");
            while (numberElements > 1)
            {
                Console.Write("input number of elements: ");
                int.TryParse(Console.ReadLine(), out numberElements);
                Console.WriteLine();
            }
            
            difference = (2 * sum - 2 * firstElement * numberElements) / (numberElements * ( numberElements - 1));
            nElement = firstElement + difference * (numberElements - 1);
            Console.WriteLine($"nth Element: {nElement}, difference: {difference}");
            #endregion
        }
    }
}