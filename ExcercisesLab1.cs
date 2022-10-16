using System;
namespace _1st_Lesson
{

	class Excercises
	{
        public static double Fact(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            return num * Fact(num - 1);
        }
        static void Main(string[] args)
			{
				#region Excercise first level number 4
				Console.Write("Introduce the value of x: ");
				double sumatory = 0;
				double x = Double.Parse(Console.ReadLine());
				for (int i = 1; i <= 9; i++)
				{
					double k = i - 1;
					double s = Math.Cos(x * i) / Math.Pow(x, k);
					s = Math.Round(s, 2);
					sumatory += s;
					Console.WriteLine($"S{i} = {s}");
					if (i >= 9)
					{
						Console.WriteLine("The sum is: " + Math.Round(sumatory, 2));
					}
				}
				#endregion
				#region Excercise first level number 9 
				double sum = 0;
				for (int i = 1; i <= 6; i++)
				{
					//Console.WriteLine(Fact(i));
					double s = Math.Pow(-1, i) * (Math.Pow(5, i) / Fact(i));
					Console.WriteLine($"S{i} = {s}");
					sum += s;
					if (i >= 6)
					{
						Console.WriteLine(sum);
					}
				}
				#endregion
				#region Excercise first level number 15
				Console.Write("Introduce the n term: ");
				double dividend, divisor = 1;
				int n = Int32.Parse(Console.ReadLine());
				for (int i = 1; i <= n; i++)
				{
					dividend = i;
					if (i % 2 == 0)
					{
						divisor++;
					}
					Console.WriteLine($"n{i}: {dividend} / {divisor}");
				}
            #endregion
				#region Excercise first level number 16
            double SumGrains = 1.0;
            int gram = 15;
            double AmountOfGrainGrams;
            for (int NumberCell = 0; NumberCell < 64; NumberCell++)
            {
                SumGrains += Math.Pow(2, NumberCell);
            }
            AmountOfGrainGrams = SumGrains / gram;
            Console.WriteLine($"Task16 {AmountOfGrainGrams}");
            #endregion
				#region Excercise first level number 18
            int cells = 10;
				for (int h = 3; h <= 24; h += 3)
				{
					cells *= 2;
					Console.WriteLine(cells);
				}
            #endregion
				#region Excercise second level number 2
            int pp = 1;
			while (pp * (pp + 3) < 30000)
			{
				pp += 3;
				Console.WriteLine(pp);
			}
            #endregion
				#region Excercise second level number 4 
            Console.WriteLine("Introduce the value of x [ -1 < x < 1 ]");
            double x_base = double.Parse(Console.ReadLine());
            if (x_base < 1 && x_base > -1)
            {
                int n_exponent = 0; // exponent
                double s_summatory = 0.0; //summatory's variable
                while (Math.Pow(x_base, n_exponent) >= 0.0001)
                {
                    s_summatory += Math.Pow(x_base, n_exponent);
                    n_exponent += 1;
                    Console.WriteLine($"n = {n_exponent} and s = {s_summatory}");
                }
            }
            else
            {
                Console.WriteLine("Introduce the value of x following the condition  [ -1 < x < 1 ] ");
            }
            #endregion
				#region Excercise second level number 7 and 8
            double path = 10000;
			double increasedPathPerDay = 0.10; // 10%
											   // Excercise A
			for (int i = 1; i <= 7; i++)
			{
				path += path * increasedPathPerDay;
			}
			Console.WriteLine($"in 7 days the runner runs {path} km");
			//Excercise B 
			path = 10000;
			double goal_path = 100000;
			int days = 0;
			//(int i = 1; i <= 7; i++)
			while (path <= goal_path)
			{
				path += path * increasedPathPerDay;
				days++;
			}
			Console.WriteLine($"in {days} days the runner achieves the 100km goal");
			//Excercise C
			path = 10000;
			days = 0;
			while (path <= 20000)
			{
				path += path * increasedPathPerDay;
				days++;
			}
			Console.WriteLine($"in {days} days the runner runs more than 20km per day");
            #endregion
				#region Excercise third level number 1
            double sum3, nSum;
            double y3;
            double product;
            for (double x3 = 0.1; x3 < 1; x3 += 0.1)
            {
                sum3 = 0;
                nSum = 0;
                int i = 0;
                product = 1.0;
                do
                {
                    nSum = Math.Pow(-1, i) * (Math.Pow(x3, 2 * i) / product);
                    sum3 += nSum;
                    i++;
                    product *= 2 * product * i * (2 * i - 1);
                }
                while (nSum >= 0.0001);
                y3 = Math.Cos(x3);
                Console.WriteLine($"X: {x3}, S: {sum3}, Y: {y3}");
            }
            #endregion
        }	
	}
}
