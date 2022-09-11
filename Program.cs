using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        { //Task 1
            const double Weight = 68;
            const double Height = 1.83;
            double ans1 = Weight / (Height*Height);
            Console.WriteLine(ans1);
            {//Task2
                const int a = 100 % 8;
                const int b = 18 - a/8;
                const double grab = 10 * 8;
                double ans2=Math.PI*(a+b)*(grab/360);
                Console.WriteLine(ans2);
                { //Task3
                    const int a0 = 8;
                    const double S = 12408.0;
                    int n;
                    int.TryParse(Console.ReadLine(), out n);
                    double ans3 = (2 * S - 2 * n * a0) / (n * (n - 1));
                    Console.WriteLine(ans3);

                }
            }
        }
