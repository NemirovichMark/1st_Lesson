using System;

namespace _1st_Lesson{
   public class Program
   {
      static void Main(string[] args)
      {
         Console.Clear();

         Console.WriteLine("Задание №1:");

         double height = 0.0;
         double weight = 0.0;

         first:
         try
         {
            Console.WriteLine("Введите ваш рост в см");
            height = Convert.ToDouble(Console.ReadLine());
            if (height <= 0.0)
            {
               Console.WriteLine("Вы ввели неккоректное значение");
               goto first;
            }
         }
         catch
         {
            Console.WriteLine("Вы ввели неккоректное значение");
            goto first;
         }

         second:
         try
         {
            Console.WriteLine("Введите ваш вес в кг");
            weight = Convert.ToDouble(Console.ReadLine());
            if (weight <= 0.0)
            {
               Console.WriteLine("Вы ввели неккоректное значение");
               goto second;
            }
         }
         catch
         {
            Console.WriteLine("Вы ввели неккоректное значение");
            goto second;
         }

         double bmi = Math.Round(weight/((height/100)*(height/100)), 2);
         Console.WriteLine($"Ваш BMI = {bmi}"); 
         if (bmi < 18.5)
         {
            Console.WriteLine("У вас недостаток веса ;(");
         }
         else if (bmi >= 18.5 && bmi < 25)
         {
            Console.WriteLine("У вас всё в порядке!!!");
         }
         else
         {
            Console.WriteLine("У вас лишний вес :(");
         }

         Console.WriteLine("-----------------------");
         Console.WriteLine("Задание №2:");

         double a = 100 % 18;
         double b = 17 - a / 18;
         double grad = 10.0 * 18.0;
         double c = 4 * (Math.PI * a * b + ((a - b)*(a - b)) / (a + b));
         Console.WriteLine($"Ответ = {c * grad / 360.0}");
         
         Console.WriteLine("-----------------------");
         Console.WriteLine("Задание №3:");

         third:
         int a0 = 18;
         int S = 10410;
         int n;
         try
         {
            Console.WriteLine("Введите кол-во членов последовательности");
            n = Convert.ToInt32(Console.ReadLine());
         }
         catch
         {
            Console.WriteLine("Вы ввели неккоректное значение");
            goto third;
         }
         if (n == 1)
         {
            Console.WriteLine($"d = {1}, an = {a0}");
         }
         else if (n == 0)
         {
            Console.WriteLine("Вы ввели неккоректное значение");
            goto third;
         }
         else
         {
         double d = (2*S - 2*a*n)/(n*(n-1));
         double an = a0 + d*(n-1);
         Console.WriteLine($"d = {Math.Round(d, 2)}, an = {Math.Round(an, 2)}");
         }
      }
   }
}