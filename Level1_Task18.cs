using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Level 1 Task 18
namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double amebas=10;
            for(int i=3; i<=24; i+=3){
                amebas*=2;
                Console.WriteLine("After {0} hours: {1}",i,amebas);
            }
        }
    }
}
