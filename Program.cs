using System;

namespace ConsoleApp1111111111
{
	class Program
	{
		static void Main(string[] args)
		{
			#region ZADANIE ADIN))
			Double bmi = (63 / (Math.Pow(1.86, 2)));
			Console.WriteLine("my bmi is " + bmi);
			#endregion



			#region ZADANIE DVA
			Double a = 100 % 17;
			Double b = 17 - (a / 17);
			int grad = 10 * 17;
			Double Perimetr = 4 * ((Math.PI * a * b + Math.Pow(a - b, 2)) / (a + b));
			Double Dlina = Perimetr / 360 * grad;
			Console.WriteLine(Dlina);
			#endregion

			#region ZADANIE TRI
			int a0 = 17;
			int s = 211004;
			int n = Int32.Parse(Console.ReadLine());
			if (n >= 1)
			{
				Double a_n = (s / n * 2) - a0;
				Double d = (a_n - a0) / (n - 1);
				Console.WriteLine($"step is {d} and nth is {a_n}");
			}
			

			#endregion

		}
	}
			
}

