//First Level.Task 4
Console.WriteLine("Enter x:");
double x = Convert.ToDouble(Console.ReadLine());
double s = 0;
double a = Math.Cos(x);
for (int i = 2; i <= 9; i++)
{
    s = s + a;
    a = Math.Cos(i * x) / Math.Pow(x, i - 1);

}
Console.WriteLine($"The answer: {s}");

//First Level.Task 9
double s = 0;
int factorial = 1;
for (int i = 1; i <= 6; i++)
{
    factorial *= i;
    s += (Math.Pow(-1, i) * Math.Pow(5, i) / factorial);
}
Console.WriteLine($"The answer: {s}");

//First Level.Task 15
int a = 1;
int b = 2;
int c = 1;
int d = 1;
int q;
int k;
for (int i = 1; i <= 3; i++)
{
    q = a + b;
    k = c + d;
    a = b;
    c = d;
    b = q;
    d = k;
}
Console.WriteLine("The answer:");
Console.WriteLine(b + "/" + d);

//First Level.Task 16
double corn = 1;
for (int i = 1; i <= 63; i++)
{
  corn+=Math.Pow(2, i);
}
corn /= 15;
Console.WriteLine(corn);
//First Level.Task 18
int s = 10;
for (int i = 3; i <= 24; i += 3)
{
     s *= 2;
     Console.WriteLine(s);
}
    

//Second Level.Task 2
using System.Xml.Schema;
int p = 1;
int maxII = 0;
for (int i = 1; p <= 30000; i += 3)
{
    if (p * (i + 3) <= 30000)
    {
        p *= i;
        maxII = i;
    }
    else break;
}
Console.WriteLine($"Max n = {maxII}");


//Second Level.Task 4
using System.Xml.Schema;
double x = Convert.ToDouble(Console.ReadLine());
double s = 1.0;
int n = 2;
if ((x > -1) & (x < 1) & (x != 0))
{
    while (Math.Abs(x) > 0.0001)
    {
      x = Math.Pow(x, n);
        s += x;
        n *= 2;
    }
}
else Console.WriteLine("Error");

Console.WriteLine($"Max n = {s}");

//Second Level.Task 4
 double x = Convert.ToDouble(Console.ReadLine());
            double s = 0.0;
            int n = 0;
 
            if ((x > -1) && (x < 1))
            {
                double a = Math.Pow (x, n);
 
                while (Math.Abs(a) > 0.0001)
                {
                    s += a;
                    n += 2;
                    a = Math.Pow(x, n);
 
                }
                Console.WriteLine($"summ = {s}");
 
            }
            else
            { 
                Console.WriteLine("Error");
            }


//Second Level.Task 7-8a
double p = 10;
double s = 0.0;
int n = 1;
while (n<=7)
{

    s += p;
    n += 1;
    p *= 1.1;
}
Console.WriteLine($"Summ way ={s} kilometers");

//Second Level.Task 7-8b
double p = 10;
double s = 0.0;
int n = 1;
while (s + p < 100)
{
    s += p;
    n += 1;
    p *= 1.1;
}
Console.WriteLine($"The number of days = {n} ");

//Second Level.Task 7-8v
double p = 10;
double s = 0.0;
int n = 1;
while (p <= 20)
{
    s += p;
    n += 1;
    p *= 1.1;
}
Console.WriteLine($"The number of days = {n} ");

 //Third level. Task 1
const double xh = 0.1, xk = 1.0, h = 0.2, eps = 0.0001;
double x, y, s, a;
int n = (int)((xk - xh) / h + 1), i;
x = xh;
for (int j = 1; j <= n; j++)
{
    s = 1; a = 1; i = 1;
    do
    {
        a = (-a * x * x) / ((2 * i - 1) * 2 * i);
        s += a;
        i += 1;
    }
    while (Math.Abs(a) >= eps);
    y = Math.Cos(x);
    Console.WriteLine("x= {0:f4} s= {1:f4} y= {2:f4}", x, s, y);
    x += h;
}

//Third level. Task 4
const double xh = 0.1, xk = 1.0, h = 0.2, eps = 0.0001, e = 2.71828;
double x, y, s, a;
int n = (int)((xk - xh) / h + 1), i;
x = xh;
for (int j = 1; j <= n; j++)
{
    s = 1; a = 1; i = 1;
    do
    {
        a = a * (2 * i + 1) * x * x / (2 * i * i - i);
        s += a;
        i += 1;
    }
    while (Math.Abs(a) >= eps);
    y = (1 + 2 * x * x) * Math.Pow (e, x * x);
    Console.WriteLine("x= {0:f4} s= {1:f4} y= {2:f4}", x, s, y);
    x += h;
}
