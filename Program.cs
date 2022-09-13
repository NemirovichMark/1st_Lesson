using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            #region task№1
            // 1. Find your BMI - body mass index

            double weight;
            int height;

            while (true)
            {
                Console.Write("Please enter weight (kilograms): ");
                if (!double.TryParse(Console.ReadLine(), out weight))
                {
                    Console.WriteLine("Wrong weight data, please try again.");
                }
                if (weight <= 0 && weight <= 300)
                {
                    Console.WriteLine("Weight have to be in range from 0 to 300 kg. Please try again.");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.Write("Please enter height (centimeter): ");
                if (!int.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Wrong height data, please try again.");
                }
                if (height <= 0 && height <= 300)
                {
                    Console.WriteLine("Height have to be in range from 0 to 300 cm. Please try again.");
                    continue;
                }
                break;
            }


            double height_ = height / 100.0;
            double height_squared = height_ * height_;

            // BMI = kg / m^2; where kg - weight in kilograms and m is a heigth in sentimeters
            double bmi = weight / height_squared;
            Console.WriteLine($"Task 1. BMI = {bmi}");
            #endregion

            #region task№2
            /* 
             * 2. Find the length of the ellipse sector curve with:
             * a = 100 % (№ in the group)
             * b = age - (a / № in the group)
             * grad = 10 * (№ in the group)
            */
            double a = 100 % 18;
            double b = 18 - (a / 18);
            double grad = 10 * 18;
            double pi = 3.141592653589793;

            Console.WriteLine($"Task 2. The length of the ellipse sector curve = {(a + b) * pi * (grad / 360)}");

            #endregion

            #region task№3
            /*
             * 3.Find the step(d) and nth term of an Arithmetic Sequence when:
             * a0 = (№ in the group)
             * S = 1ddmm of your birth day
             */
            int first_elem = 18;
            int s = 11702;
            int counter;

            while (true)
            {
                Console.WriteLine("Please enter counter: ");
                if (!int.TryParse(Console.ReadLine(), out counter))
                {
                    Console.WriteLine("Wrong data, please try again.");
                    continue;
                }
                break;
            }
                int last_elem = (s / counter) * 2 - first_elem;
                double step = (last_elem - first_elem) / counter;

            Console.WriteLine($"Task 3. Last element: {last_elem}\n        Step: {step}");
            #endregion

        }
    }
}

