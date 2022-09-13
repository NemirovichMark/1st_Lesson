using System;
namespace Homework_1
{
    class Main_Prog
    {


        static void Telling_Ur_BMI(float height, float weight)
            {
                float BMI;
                try
                {
                    BMI = weight/(height*height);
                    Console.WriteLine($"Your BMI is {BMI}!");
                }
                catch
                {
                    Console.WriteLine("Please, enter your real parameters");
                }
            }



        static void Calculating_Step_And_Nth_Elem(int A_0, int Sum_Of_Sequence, int Number_Of_Elems)
            {
                float Step;
                float Nth;
                try
                {
                    Step = ((2 * Sum_Of_Sequence / Number_Of_Elems) - 2 * A_0)/(Number_Of_Elems - 1);
                    Nth = A_0 + Step*(Number_Of_Elems-1);
                    Console.WriteLine($"Step = {Step}, Nth = {Nth}");
                }
                catch
                {
                    Console.WriteLine("Please, enter real parameters");
                }
            }


   
        static void Main(string[] args)
        {
            #region First_Task
            //Я не совсем понял, что от меня требуется, поэтому написал маленький статичный метод, вычисляющий индекс массы тела.
            float weight = 78.0;
            float height = 1.78;
            Telling_Ur_BMI(height, weight);
            #endregion



            #region Second_Task
            int Number_In_Group = 17; //Пусть будет 17, т.к. я не знаю свой номер в группе
            int Age = 18;
            try
            {
                float First_Half_Axis = Number_In_Group;
                float Second_Half_Axis = Age - (First_Half_Axis / Number_In_Group);
                float Grade = 10 * Number_In_Group;
                float PI = 3.1415926535f;
                float Len_Of_Ellipse_Sector_Curve = (Grade/360) * PI * (First_Half_Axis + Second_Half_Axis);
                Console.WriteLine($"Length of the ellipse sector curve is {Len_Of_Ellipse_Sector_Curve}!");
            }
            catch
            {
                Console.WriteLine("Please, enter your real parameters");
            }
            #endregion



            #region Third_Task
            //Не совсем понимаю, как можно найти шаг и n-ый элемент не зная количество элементов,
            //поэтому написал метод, который в зависимости от n находит эти значения
            int A_0 = 17;
            int Sum_Of_Sequence = 11704;
            int Number_Of_Elems = Int32.Parse(Console.ReadLine());; //Введите сюда нужное количество элементов арифмитической последовательности
            Calculating_Step_And_Nth_Elem(A_0, Sum_Of_Sequence, Number_Of_Elems);
            #endregion
        }
    }
}