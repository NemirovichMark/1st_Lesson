using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tasks:
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
            #endregion
            #region Task 1
            static void BMIFormula()
            {
                Console.WriteLine("You've chosen Function (Finding BMI)");
                Console.WriteLine("Type you mass: (it should be float)");
                try
                {
                    float weight = float.Parse(Console.ReadLine());
                    Console.WriteLine("Type your height in cm: (it should be float)");
                    float height = float.Parse(Console.ReadLine());
                    height = height * 0.01f;
                    float bmi = (float)(weight / Math.Pow(height, 2));
                    Console.WriteLine($"Your BMI is {bmi} ");
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Oops, that's the wrong number! \n Just kidding, you've writen something wrong :( ");
                }

            }
            #endregion

            #region Task 2
            static void LengthOfEllipse()
            {
                const double a = 15;
                const double b = 4;
                const double grad = 170;
                const double pi = Math.PI;

                Console.WriteLine("You've chosen Function (Finding length of ellipse curve)");
                Console.WriteLine($"a is :{a}");
                Console.WriteLine($"b is :{b}");
                Console.WriteLine($"grad is :{grad}");

                try
                {
                    double P = 4 * ((pi * a * b + (a - b)) / (a + b));
                    double length = P / 360 * grad;

                    Console.WriteLine($"Length is {length} ");
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Oops, that's the wrong number! \n Just kidding, you've writen something wrong :( ");
                }

            }
            #endregion

            #region Task 3
            static void Step()
            {
                const double a1 = 17;
                const double S = 10910;

                Console.WriteLine("You've chosen Function (Finding step of Arithmetic Sequence and n-th term)");
                Console.WriteLine($"a1 is {a1}");
                Console.WriteLine($"S is {S}");
                Console.WriteLine("Type n(Amount of):");
                try
                {

                    int n = int.Parse(Console.ReadLine());
                    double d = ((2 * S) / n - 2 * a1) / (n - 1);
                    Console.WriteLine($"d is {d} ");
                    double a_nth = a1 + d * (n - 1);
                    Console.WriteLine($"a-nth is {a_nth} ");
                    Console.ReadKey();
                }
                catch
                {
                    Console.WriteLine("Oops, that's the wrong number! \nJust kidding, you've writen something wrong :( ");
                }

            }
            #endregion


            #region Main Part

            Console.WriteLine("Hello, dear friend! \nPlease choose Function, that you like \nThere are 3 Options: \n \t" +
                "1) Formula of BMI \n\t2) Formula of Length of ellipse curve \n\t3) Formula of Arithmetic Sequence \n\nChoose one of them and type its number. ");

            
                int numOfFunc = int.Parse(Console.ReadLine());
                switch (numOfFunc)
                {
                    case 1:
                        BMIFormula();
                        break;
                    case 2:
                        LengthOfEllipse();
                        break;
                    case 3:
                        Step();
                        break;
                    default:
                        Console.WriteLine("You are out of range. Please, try again.");
                        break;
                }
            
            
            #endregion



        }
    }
}
