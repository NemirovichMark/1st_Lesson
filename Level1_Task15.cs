using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Level 1 Task 15
namespace Sololearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] chisl = new double[5]{1,2,0,0,0};
            double[] znam = new double[5]{1,1,0,0,0};
            for(int i=2; i<5; i++){
                chisl[i]=chisl[i-1]+chisl[i-2];
                znam[i]=znam[i-1]+znam[i-2];
            }
            Console.WriteLine(chisl[4]/znam[4]);
            //Т.к. индексация массивов начинается с 0, выводим элементы с индексом 4
        }
    }
}
