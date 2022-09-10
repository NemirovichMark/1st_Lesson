using System;
using System.Dynamic;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Numerics;
using System.Security.Cryptography;
using System.Transactions;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

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
            //TASKS
            #region task_1
            m1:
            try
            {
                Console.WriteLine("your weight(kilo, you have to use comma):");
                double mass = double.Parse(Console.ReadLine());
                Console.WriteLine("your height(meter, you have to use comma) :");
                double height = double.Parse(Console.ReadLine());
                if (mass <= 0 || height <= 0)
                {
                    throw new Exception();
                }
                double result = mass / (height * height);
                Console.WriteLine($"your weight: {mass}\nyour height: {height}\nyour BMI: {result}" + "\n\n\n\n\n\n");
            }
            catch
            {
                Console.WriteLine("you made sonething wrong, try again.");
                goto m1;
            }
            #endregion
            #region task_2
            // Here I did without input Just for a change
            double a = 3.57;
            double b = 16.87;
            int grad = 280;
            double resultt = 3.14 * (a + b) / 360 * grad;
            Console.WriteLine($"the length of the ellipse sector curve: {resultt}\na = {a}\nb = {b}\ngrad = {grad}");
            #endregion
            #region task_3
            /* I understand that the sequence is finite and
               I have to enter the number of members myself
            */
            double a0 = 28;
            double s = 12411;
            m2:
            try
            {
                Console.WriteLine("quality: ");
                int quality = int.Parse(Console.ReadLine());
                if (quality <= 0)
                {
                    throw new Exception();
                }
                double d = (2 * s / quality - 2 * a0) / (quality - 1);
                double nth_term = a0 + (quality - 1) * d;
                Console.WriteLine($"d = {d}\nnth_term = {nth_term}");

            }
            catch
            {
                Console.WriteLine("you made sonething wrong, try again.");
                goto m2;
            }
            
            #endregion

