using System;
namespace Firsthomework
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = 52.0;
            double height = 1.55;
            double result1 = weight/(Math.Pow(height,2)); 

            Console.WriteLine("The first task: Find your BMI - body mass index");
            Console.WriteLine($"weight ->  {weight} ");
            Console.WriteLine($"height -> {height}");
            Console.WriteLine($"BMI -> {result1}");


            const double PI = 3.1415926535897931;
            double a = 100 % 8;
            double b = 17 - (a/8);
            double grad = 10 * 8;
            double result2 = (a+b)*PI*Math.Sin(PI*grad/180);
            Console.WriteLine("the second task: Find the length of the ellipse sector curve:");
            Console.WriteLine($"the length of the ellipse sector curve -> {result2}");


            int a0 = 8;
            int s = 12812;
            Console.WriteLine("the third task: Find the step (d) and nth term of an Arithmetic Sequence:");
            Console.Write("n -> ");
            int n = Convert.ToInt32(Console.ReadLine());
            int an = 2*s/n -a0;
            int d = (an-a0)/(n-1);
            Console.WriteLine($"d -> {d}, an-> {an}");
        }
    }
}
