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
            double s=0,x=0;
            string vvod;
            while(true){
                vvod = Console.ReadLine();
                double.TryParse(vvod,out x);
                if(x>=1||x<=-1){
                    Console.WriteLine("|x| need to be less than 1, try again: ");
                }
                else if(x==0&&vvod!="0") Console.WriteLine("Something's wrong, try type it again: ");
                else break;
            }
            for(int i=0; Math.Pow(x,i)>=0.0001;i+=2){
                s+=Math.Pow(x,i);
            }
            Console.WriteLine(s);
        }
    }
}
