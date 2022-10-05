using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double s=0,x=1;
            do{
                Console.WriteLine("Introduce the value of x(x!=0): ");
                double.TryParse(Console.ReadLine(),out x);
                if(x==0) Console.WriteLine("No no no, x doesn't equal 0!!! Try again");
            }
            while(x==0);
            for(int i=1; i<=9; i++){
                s+=Math.Cos(x*i)/Math.Pow(x,i-1);
            }
            Console.WriteLine(s);
        }
    }
}
