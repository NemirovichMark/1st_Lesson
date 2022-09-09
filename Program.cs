using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Body mass index
            double weight = 58.2;
            double height = 1.653;
            double bmi = Math.Round(weight / (height * height), 3);

            Console.WriteLine($"My body mass index is: {bmi}");
            #endregion

            #region Ellipse sector curve length
            int numInGroup = 1;
            double a = 100.0 % numInGroup;

            double b = 20.0 - (a / numInGroup);
            double grad = 10 * numInGroup;

            double perimeter = 4 * (Math.PI * a * b + ((a - b) * (a - b))) / (a + b);
            double curveLength = Math.Round(perimeter * grad / 360.0, 3);

            Console.WriteLine($"Ellipse sector curve length is: {curveLength}");
            #endregion

            #region Arithmetic Sequence
            int a0 = 1;
            int S = 11702;

            Console.WriteLine("Arithmetic sequence: There isn't enough data for solving this task correctly (see the comments)");

            /* Explanation
             *
             * In the task conditions we have only two variables specified - a0 and S.
             * 
             *                              2a1 + d(n-1)
             * The formula for S is: Sn = --------------- * n
             *                                   2
             * 
             *                                2 + d(n-1)
             * With my data we get: 11702 = --------------- * n 
             *                                    2
             *                                    
             * So we have an equation with two variables. And that means we have a set of answers
             * witout any criteria to pick one, that fits for us.
             * 
             * Even if we try to use brute-force method to find variable d we will get at least two possible answers,
             * just because we always have one obvious, where d = 1. And it might be a right solution, because using d = 1 we
             * can find other variables.
             */
            #endregion
        }

        /* Tasks:
             * 1. Find your BMI - body mass index
             * 
             * 2. Find the length of the ellipse sector curve with:
             *  a = %(№ in the group)
             *  b = age - (a / № in the group)
             *  grad = 10 * (№ in the group)
             * 
             * 3. Find the step (d) and nth term of an Arithmetic Sequence when:
             *  a0 = (№ in the group)
             *  S = 1ddmm of your birth day
             */
    }
}
