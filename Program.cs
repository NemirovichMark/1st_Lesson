using System;

namespace _1st_Lesson
{
    
    class Program
    {
        const int GROUPNUMBER = 17;
        const int AGE = 18;

        static void Main(string[] args)
        {
            #region Exisise_1
            try
            {
                double height = 1.77; // метры
                double weight = 66; // килограмм
                double BMI = weight / (height * height);
                Console.WriteLine($"мой BMI приблизительно саставляет {BMI} кг/м*м при росте {height} м и массе {weight} кг");
            }
            catch
            {
                Console.WriteLine("возникло иключение в регионе Exisise_1");
            }
            finally
            {

            }
            #endregion

            #region Exisise_2
            try
            {
                double a = 100 % GROUPNUMBER; // первая полуось
                double b = AGE - a / GROUPNUMBER; // вторая полуось
                double grad = 10 * GROUPNUMBER; // угол
                double ellipseLength = Math.PI * (a + b); // длина элипса
                double ans = (grad / 360) * ellipseLength; //длина кривой сектора эллипса
                Console.WriteLine($"длина кривой сектора эллипса {ans}");
            }
            catch
            {
                Console.WriteLine("возникло иключение в регионе Exisise_2");
            }
            finally
            {

            }
            #endregion

            #region Exisise_3
            try
            {
                int n;
                string st;
                Console.WriteLine("ведите значение n (n>1) иначе невозможно определить шаг арифметической прогрессии");
                st = Console.ReadLine();
                n = int.Parse(st);
                if (n <= 1) 
                {
                    n = n / 0;
                }
                int s = 11407; // сума первых n элементов арифметической прогрессии
                double a1 = GROUPNUMBER; // первый элемент в арифметической прогрессии
                double an = 2 * s / n - a1; // n-й элемент в арифметической прогрессии
                double d = (an - a1) / (n - 1); // шаг арифметической прогрессии
                Console.WriteLine($"шаг арифметической прогрессии {d}, n-й элемент в арифметической прогрессии {an}");
            }
            catch
            {
                Console.WriteLine("возникло иключение в регионе Exisise_3");
            }
            finally
            {

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