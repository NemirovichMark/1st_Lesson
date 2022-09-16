using System;

namespace _1st_Lesson{
   public class Program
   {
      static void Main(string[] args)
      {
         Console.Clear();

         Console.WriteLine("№1:");

         double height = 0.0;
         double weight = 0.0;

         first:
         try
         {
            Console.WriteLine("Enter your height (CM)");
            height = Convert.ToDouble(Console.ReadLine());
            if (height <= 0.0)
            {
               Console.WriteLine("Error");
               goto first;
            }
         }
         catch
         {
            Console.WriteLine("Error");
            goto first;
         }

         second:
         try
         {
            Console.WriteLine("Enter your weight (KG)");
            weight = Convert.ToDouble(Console.ReadLine());
            if (weight <= 0.0)
            {
               Console.WriteLine("Error");
               goto second;
            }
         }
         catch
         {
            Console.WriteLine("Error");
            goto second;
         }

         double bmi = Math.Round(weight/((height/100)*(height/100)), 2);
         Console.WriteLine($"Your BMI = {bmi}"); 
         if (bmi < 18.5)
         {
            Console.WriteLine("Your BMI is low ;(");
         }
         else if (bmi >= 18.5 && bmi < 25)
         {
            Console.WriteLine("Your BMI is allright");
         }
         else
         {
            Console.WriteLine("Your BMI is big ;(");
         }

         Console.WriteLine("-----------------------");
         Console.WriteLine("№2:");

         double a = 100 % 21;
         double b = 17 - a / 21;
         double grad = 10.0 * 21.0;
         double c = 4 * (Math.PI * a * b + ((a - b)*(a - b)) / (a + b));
         Console.WriteLine($"Answer = {c * grad / 360.0}");
         
         Console.WriteLine("-----------------------");
         Console.WriteLine("№3:");

         third:
         int a0 = 21;
         int S = 10410;
         int n;
         try
         {
            Console.WriteLine("Enter n");
            n = Convert.ToInt32(Console.ReadLine());
         }
         catch
         {
            Console.WriteLine("Error");
            goto third;
         }
         if (n == 1)
         {
            Console.WriteLine($"d = {1}, an = {a0}");
         }
         else if (n == 0)
         {
            Console.WriteLine("Error");
            goto third;
         }
         else
         {
         double d = (2*S - 2*a0*n)/(n*(n-1));
         double an = a0 + d*(n-1);
         Console.WriteLine($"d = {Math.Round(d, 2)} an = {Math.Round(an, 2)}");
         }
      }
   }
}