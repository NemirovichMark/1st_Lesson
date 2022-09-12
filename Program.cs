using System;

namespace _1st_Lesson

{
    class Program
    {
        static void Main(string[] args)
        {

=======

            }
            {//EX2
                const int a = 100 % 8;
                const int b = 18 - a / 8;
                const double grab = 10 * 8;
                double ans2 = Math.PI * (a + b) * (grab / 360);
                Console.WriteLine(ans2);
            }
            {//EX3
                const int a0 = 8;
                const double S = 12408.0;
                int n=int.Parse(Console.ReadLine());
                double ans3 = 0;
                if (n != 0)
                {
                    ans3 = (2 * S - 2 * n * a0) / (n * (n - 1));
                }
                else
                {
                    ans3 = 0;
                }
                
                Console.WriteLine(ans3);

            }
            
        }

    }

}
