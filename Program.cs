using System;

namespace Homework12_sep
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            double body_weigh = 83.8;
            double lenght_body = 1.83;
            double BMI = body_weigh / (lenght_body * 1.83);
            Console.WriteLine("Индект ИМТ моего тела " + BMI);
            #endregion

            #region task 2
            Console.WriteLine("Мой номер в группе - 24");
            int nomer_group = 24;
            double dlina_a = 100 % nomer_group;
            Console.WriteLine("Мой возраст - 18 лет");
            int age = 18;
            double dlina_b = age - (dlina_a / 24);
            double gradusi = 10 * nomer_group / 180;
            double dlina_sectora = 3.14 * (dlina_a + dlina_b) * Math.Sin(gradusi);
            Console.WriteLine("Ура,длина сектора " + dlina_sectora + "!");
            Console.ReadLine();
            #endregion
           
                
                
             #region task 3

            Console.WriteLine("Моя дата рождения - 12.11.2003");
            int S = 1211;
            Console.WriteLine("Мой номер в группе - 24");
            int a0 = 24;
            Console.WriteLine("Введите кол-во членов арифмитической последовательности");
            int n = Int32.Parse(Console.ReadLine());
            if (n > 0)
            {
                double d = ((2 * S / n) - 2 * a0) / (n - 1);
                Console.WriteLine("Разница между двумя членами последовательности равняется " + d + "!");
            }
            else
            {
                Console.WriteLine("Иди учить математику! ");
            }
            Console.ReadLine();
            #endregion

               
        }
    }
}
