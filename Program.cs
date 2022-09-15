using System;

namespace _1st_Lesson
{
  class Program
  {
    static void Main(string[] args)
    {
      #region task 1
      double weigh = 68.6;
      double lenght = 1.89;
      double BMI = weigh / (lenght * lenght);
      Console.WriteLine("Мой ИМТ составояет " + BMI);
      #endregion 

      #region task 2
      double a = 100%1;
      double b = 17 - (a/1) ;
      double grad =( 3.14 * (10 * 1))/180 ;
      double L=3.14 * (a+b) * Math.Sin(grad) ;
      Console.WriteLine("Длина сектора " + L);
      #endregion 

      #region task 3
      double a0 = 1;
      double s = 10201;
      Console.WriteLine("Введите количество n-ных членов ");
      int n=Convert.ToInt32(Console.ReadLine());
      if (n>0)
      {
        double an = (2 * s) / n - a0;
        double d = (((2 * s) / n) - 2 * a0) / (n - 1);
        Console.WriteLine("Разница между членами последовательности " + d);
      }
      else
      {
       Console.WriteLine("n введён не правильно "); 
      }
       Console.ReadLine();
      #endregion
    }
  }
}
