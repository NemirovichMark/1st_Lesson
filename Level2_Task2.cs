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
            int p=1,L=30000,n=1;
            for(int i=1; (p*=i)<=L; i+=3) n=i;
            Console.WriteLine("The max n is {0}",n);
        }
    }
}
