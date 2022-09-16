
namespace _1st_Lesson
{
    class Program
    {
        static void Main(string [] args)
        {
            #region Task_1
            double weight = 67.0;
             double height = 1.85;
              double bmi = weight / (height * height);

            Console.WriteLine(bmi);
            #endregion


            #region Task_2
            double P = 3.14159;
             double a = 100 % 18;
              double b = 17 - (a / 18);
               double grad = 10 * 18;

            Console.WriteLine((a + b) * P * (grad / 360));
            #endregion
                 
                
            #region Task_3
        int a0 = 17;
         int s = 10612; 
        Console.WriteLine(" Введите n: ");
        int n = Convert.ToInt32(Console.ReadLine () );     
            double a = (s * 2) / n - a0;
             double d = (a - a0) / n;
        Console.WriteLine(a);
         Console.WriteLine(d);
        #endregion

        }

    }
}
