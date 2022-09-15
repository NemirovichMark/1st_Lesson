using System;

namespace _1st_Lesson
{
    
    class Program
    {
        const int GROUPNUMBER = 17;
        const int AGE = 18;

        static void OutputError(int n)
        {
            Console.WriteLine($"возникло иключение в регионе Exisise_{n}");
        }

        static void Main(string[] args)
        {
            #region Exisise_1

            double height = 1.77; // метры
            double weight = 66; // килограмм
            if (height == 0)
            {
                OutputError(1);
            }
            else
            {
                double BMI = weight / (height * height);
                Console.WriteLine($"мой BMI приблизительно саставляет {BMI} кг/м*м при росте {height} м и массе {weight} кг");
            }
            #endregion

            #region Exisise_2
            
            double a = 100 % GROUPNUMBER; // первая полуось
            double b = AGE - a / GROUPNUMBER; // вторая полуось
            double grad = 10 * GROUPNUMBER; // угол
            double ellipseLength = Math.PI * (a + b); // длина элипса
            double ans = (grad / 360) * ellipseLength; //длина кривой сектора эллипса
            Console.WriteLine($"длина кривой сектора эллипса {ans}");
            
            #endregion

            #region Exisise_3

            int n;
            string st;
            Console.WriteLine("ведите значение n (n>1) иначе невозможно определить шаг арифметической прогрессии");
            st = Console.ReadLine();
            bool fl;
            fl = int.TryParse(st, out n);
            int s = 11407; // сума первых n элементов арифметической прогрессии
            double a1 = GROUPNUMBER; // первый элемент в арифметической прогрессии
            if (n <= 1 || n == a1 || !fl)
            {
                OutputError(3);
            }
            else
            { 
                double an = 2 * s / n - a1; // n-й элемент в арифметической прогрессии
                double d = (an - a1) / (n - 1); // шаг арифметической прогрессии
                Console.WriteLine($"шаг арифметической прогрессии {d}, n-й элемент в арифметической прогрессии {an}");
            }

            #endregion
            /* Tasks:
             * 1. Find your BMI - body mass index
             * 
             * 2. Find the length of the ellipse sector curve with:
             *  a = 100 % (№ in the group)
             *  b = age - (a / № in the group)
             *  grad = 10 * (№ in the group)
             * 
             * 3. Find the step (d) and nth term of an Arithmetic Sequence when:
             *  a0 = (№ in the group) ..
             *  S = 1ddmm of your birth day
             */
        }
    }
}