using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Task
            double a0 = 29;
            double S = 11002;
            Console.WriteLine("Introduce the n: ");
            double n;
            if(!double.TryParse(Console.ReadLine(), out n) || n<=0){
                Console.WriteLine("Error");
                return;
            }
            n+=1;
            double d = (2*S-2*a0*n)/(4*(n-1));
            double an = a0 + d*(n-1);
            Console.WriteLine($"d = {d}\nan = {an}");
            #endregion
		}
	}
}
