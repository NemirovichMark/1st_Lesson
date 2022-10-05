using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Level 2 Task 4
namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double s=0,x;
            double.TryParse(Console.ReadLine(),out x);
            for(int i=0; Math.Pow(x,i)>=0.0001;i+=2){
                s+=Math.Pow(x,i);
            }
            Console.WriteLine(s);
        }
    }
}
