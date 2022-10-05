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
            #region A
            decimal s=0m; //Summ Length
            decimal k=10m; //Length per day
            for(int i=0; i<7; i++){
                s+=k;
                k*=1.1m; //Increasing Length per day by 10%
            }
            Console.WriteLine("Path after 7 days: {0}",s);
            #endregion
            
            #region B
            int days=0; //Counter of days
            s=0m;
            k=10m;
            while(s<=100){
                s+=k;
                k*=1.1m;
                ++days;
            }
            Console.WriteLine("Sportsman will run more than 100km at the {0}th day",days);
            #endregion
            
            #region C
            days=0; //Counter of days
            s=0m;
            k=10m;
            while(k<=20m){
                s+=k;
                k*=1.1m;
                ++days;
            }
            Console.WriteLine("Sportsman will run once a day more than 20km at the {0}th day",days);
            #endregion
        }
    }
}
