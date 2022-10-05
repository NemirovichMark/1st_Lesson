using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Level 1 task 16
namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal s=0;
            for(int i=0; i<64; i++){
                s+=Pow2To(i);
            }
            Console.WriteLine("Result is: {0}",s);
            Console.WriteLine("Result obtained with 100% accuracy");
        }
        
        //Method, that returns 2^a
        static decimal Pow2To(int a){
            if(a==0) return 1m;
            if(a%2==0) return Pow2To(a/2)*Pow2To(a/2);
            return 2m*Pow2To(a-1);
        }
    }
}
