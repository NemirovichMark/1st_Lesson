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
            Console.WriteLine("Introduce your weight(kg): ");
            double weight;
            if(!double.TryParse(Console.ReadLine(), out weight)){
                Console.WriteLine("Error");
                return;
            }
            Console.WriteLine("Introduce your height(cm): ");
            double height;
            if(!double.TryParse(Console.ReadLine(), out height)){
                Console.WriteLine("Error");
                return;
            }
            double BMI=10000*weight/height/height;
            Console.WriteLine($"Your BMI equals: {BMI}");
            #endregion
		}
	}
}
