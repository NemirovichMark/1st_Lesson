using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Level 1 task 9
namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double s=0;
            for(int i=1; i<=6; i++){
                s+=Math.Pow(-1,i)*Math.Pow(5,i)/i;
            }
            Console.WriteLine(s);
        }
        static int fact(int n){
            return n*fact(n-1);
        }
    }
}
