//1
using System;
class Programm
{
    public static void Main(string[] args)
    {
        float mass=80;
        float lengh=0f;
        float bmi;
        if(lengh!=0){
            bmi=mass/(lengh*lengh);
            Console.WriteLine("My bmi is " + bmi);
        }
        else{
            Console.WriteLine("Error");           
        }        
    }
}
//2
using System;

class Programm
{
    public static void Main(string[] args)
    {
        double a=100%29;
        double b=17-(a%29);
        double P=0;
        double Len=0;
        double grad=10*29;
        if(a!=0 && b!=0 && grad!=0){
            P=(4*(Math.PI*a*b+(a-b))/(a+b));
            Len=P/360*grad;
            Console.WriteLine("length of the ellipse sector is " + Len);
            
        }
        else{
            Console.WriteLine("Error");
        }
    }
}
//3
using System;
    class HelloWorld {
        static void Main() {
            int a0=29;
            int S=12409;
            Console.WriteLine("Enter the member number of the progression:");
            int n=Convert.ToInt32(Console.ReadLine());
            if(n!=1 && n!=29 && n!=0){
                double N=2*S/n-a0;
                double Step=(N-a0)/(n-1);
                Console.WriteLine("The step is " + Step);
                Console.WriteLine("The term is " + N);  
            } 
            else{
                Console.WriteLine("Error");
            }
        }
    }
