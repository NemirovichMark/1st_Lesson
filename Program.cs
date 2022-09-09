using System;

namespace _1st_Lesson {
    class Program {
        static void Main(string[] args) {
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

            // 1
            int body_mass = 65;
            double height = 1.8;
            double BMI = body_mass / Math.Pow(height, 2);
            Console.WriteLine($"1. {BMI}");

            // 2
            double a = 100 % 17;
            double b = 17 - (a / 17);
            double degree = 10 * 17;

            double sectorLength = Math.PI * (a + b) * (degree / 360);
            Console.WriteLine($"2. {sectorLength}");

            // 3
            double first_elem = 17;
            double s = 12209;
            if (!int.TryParse(Console.ReadLine(), out int cnt)) {
                Console.WriteLine("Input not correct!");
                return;
            }
            double last_elem = (s / cnt) * 2 - first_elem;
            double step = (last_elem - first_elem) / (cnt - 1);
            Console.WriteLine($"3. Last element: {last_elem}\n   Step: {step}");
        }
    }
}
