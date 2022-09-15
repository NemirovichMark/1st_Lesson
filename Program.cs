
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


        }

    }
}
