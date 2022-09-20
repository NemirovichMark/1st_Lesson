using System;

namespace FirstLab
{
    class Program
    {
        static void Main()
        {   
            //1
            double height = 1.9;
            double weight = 63;
            Console.WriteLine(weight / Math.Pow(height, 2));
            //2
            double a = 100 & 17;
            double b = 18 - (a / 17);
            double grad = 10 * 17;
            Console.WriteLine(Math.PI * (a + b) + (grad / 360));
            //3
            double frs_e = 17;
            double s = 11008;
            if (!int.TryParse(Console.ReadLine(), out int cnt))
            {
                Console.WriteLine("Ввод неверен!");
                return;
            }
            double lst_e = (s / cnt) * 2 - frs_e;
            double step = (lst_e - frs_e) / (cnt - 1);
            Console.WriteLine($"Last element: {lst_e} Step: {step}");
        }
    }
}