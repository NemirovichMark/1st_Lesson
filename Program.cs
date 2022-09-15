using System;

namespace _1st_Lesson
{
    class Program
    {
        static void task_1(double weight, double height)
        {
            #region 1st task
            
            double BMI;
            height = Math.Pow(height / 100, 2);
            BMI = (weight / height);
            
            Console.WriteLine($"Your BMI is: {BMI}");
            
            #endregion
        }
        static void task_2()
        {
            #region 2nd task

            const int age = 18;
            const int group_number = 11;
            
            double a = (100 % group_number);
            double b = age - (a / group_number);
            int grad = 10 * group_number;

            double length_full = 4 * (((Math.PI * a * b + Math.Pow(a - b, 2)) / (a + b)));
            double length = (grad * length_full) / 360;
            Console.WriteLine($"Length of the ellipse sector curve is {length}");

            #endregion
        }
        static void task_3(int amount)
        {
            #region 3rd task

            const int a0 = 11;
            const int s = 12903;
            
            double an = (2 * s / amount) - a0;
            double step = (an - a0) / (amount - 1);
            Console.WriteLine($"Step of the sequence is: {step}. nth term: {an}");

            #endregion
        }
        static void Main()
        {
            #region task selection
            
            Console.WriteLine("Lab 1\nPlease enter number of the task from the list to run it:");
            Console.WriteLine("1. BMI calculator\n2. Length of the ellipse sector curve calculator\n3. Arithmetic Sequence information");
            
            bool flag = false;
            int answer = 0;
            while (flag == false){
                Console.WriteLine("Your choice: ");
                string input = Console.ReadLine();
    
                bool result = int.TryParse(input, out var number);
                if (result == true && (number >= 1) && (number <= 3))
                {
                    flag = true;
                    answer = number;
                }
            }
            
            #endregion
            
            if (answer == 1)
            {
                flag = false;
                while (flag == false)
                {
                    Console.WriteLine("Enter your height(meters): ");
                    string input1 = Console.ReadLine();
                    bool result1 = double.TryParse(input1, out var height);
                    if (result1 == true && height > 0)
                    {
                        Console.WriteLine("Enter your weight(kg): ");
                        string input2 = Console.ReadLine();
                        bool result2 = double.TryParse(input2, out var weight);
                        if (result2 == true && weight > 0)
                        {
                            flag = true;
                            task_1(weight, height);
                        }
                    }
                }
            }
            if (answer == 2)
            {
                task_2();
            }
            if (answer == 3)
            {
                flag = false;
                while (flag == false)
                {
                    Console.WriteLine("Enter the amount of sequence numbers: ");
                    string input3 = Console.ReadLine();
                    bool result3 = int.TryParse(input3, out var amount);
                    if (result3 == true && amount > 1)
                    {
                        flag = true;
                        task_3(amount);
                    }
                    if (result3 == true && amount == 1)
                    {
                        Console.WriteLine("Couldn't be done because sum of the sequence is greater than its 1st number");
                    }
                }
            }
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
        }
    }
}