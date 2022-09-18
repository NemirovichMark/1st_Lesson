using System;
namespace Lab_1
{
    
    class Main_Prog
    {

        public static double Fact(double num) {

            if(num == 0)
                return 1;
            else
                return num * Fact(num - 1);

            }

        public static double Fibonacci_Num(double num1, double num2, int times) {
            if(times == 0)
            return num1+num2;
            else
            return Fibonacci_Num(num2, num1+num2, times-1);
        }
        public static decimal Dubl(decimal gram, int amount) {
            if(amount == 1)
            return gram*2;
            else
            return Dubl(gram*2, amount-1);
        }
        public static string Cells(int num, int time){
            Console.WriteLine($"Time : {time}, Cells : {num}");
            if(time < 24)
                return Cells(num*2, time+3);
            
            else
            return "The end";
        }

        static void Main(string[] args)

        {

            #region First_Lvl_4
            double grad = Convert.ToDouble(Console.ReadLine());
            if(grad==0)
            Console.WriteLine("Wrong grad!!!")
            else
                double sum = 0;
                for (double i = 1; i < 10; i++)
                    sum += (Math.Cos(grad*i))/Math.Pow(grad, (i-1));        
                Console.WriteLine(sum);
            #endregion

            #region First_Lvl_9
            double sum = 0;
            for (double i = 1; i < 7; i++)
                sum += Math.Pow(-1, i) * Math.Pow(5, i) / Fact(i);     
            Console.WriteLine(sum);
            #endregion

            #region First_Lvl_15
            Console.WriteLine(Fibonacci_Num(1, 2, 2) / Fibonacci_Num(1, 1, 2));
            #endregion

            #region First_Lvl_16
            Console.WriteLine(Dubl(1, 64)/15);
            #endregion

            #region First_Lvl_18
            Console.WriteLine(Cells(10, 0));
            #endregion

            #region Second_Lvl_2
            int n = 1;
            int sum = n;
            while(true){
                sum *= n+3;
                if (sum > 30000){
                    Console.WriteLine($"The last n is {n}");
                    break;
                }
                n += 3;
            }
            #endregion

            #region Second_Lvl_4
            
            double x = Convert.ToDouble(Console.ReadLine());
            
            if((x<=0) && (x>=1))
                Console.WriteLine("Please, enter right x!");
            else {
                double sum = 1;
                while(x >= 0.0001){
                    x *= x;
                    sum += x;
                }
                Console.WriteLine($"The answer is {sum}");
            }
            #endregion

            #region Second_Lvl_7-8_A
            double point = 10;
            double Q = 1.1;
            double Sum = 10;
            int Days = 0;
            while(Days!=6){
                Days += 1;
                point *= Q;
                Sum += point;
            }
            Console.WriteLine(Sum);
            #endregion

            #region Second_Lvl_7-8_B
            double point = 10;
            double Q = 1.1;
            double Sum = 10;
            int Days = 0;
            while(Sum<100){
                Days += 1;
                point *= Q;
                Sum += point;
            }
            Console.WriteLine(Days+1);
            #endregion

            #region Second_Lvl_7-8_C
            double point = 10;
            double Q = 1.1;
            double Sum = 10;
            int Days = 0;
            while(point<=20){
                Days += 1;
                point *= Q;
                Sum += point;
            }
            Console.WriteLine(Days+1);
            #endregion

            #region Third_Lvl_1
            for(double x=0.1; x<1.1; x+=0.1){
                double y = Math.Cos(x);
                double sum = 0;
                double i = 1;
                double elem = -1;
                do{
                    elem = (elem*(-1)*Math.Pow(x, 2))/(2*i*(2*i-1));
                    sum += elem;
                    i += 1;
                }while(elem>0.0001);
                Console.WriteLine($"X : {x}, Y : {y}, Sum : {sum}");
            }
            #endregion
            
            #region Third_Lvl_8
            for(double x=0.1; x<1.05; x+=0.05){
                double y = Math.Pow(Math.E, 2*x);
                double sum = 0;
                double i = 1;
                double elem = 1;
                do{
                    elem = (elem*2*x)/i;
                    sum += elem;
                    i += 1;
                }while(elem>0.0001);
                Console.WriteLine($"X : {x}, Y : {y}, Sum : {sum}");
            }
            #endregion

        }
    }
}
