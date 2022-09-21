double h = 1.65;
int v = 44;
Console.WriteLine(v / (h * h));
int a = 100 % 5;
double b = 17 - (a / 5);
int grad = 10 * 5;
Console.WriteLine(Math.PI * (a + b) * Math.Sin(grad));
int a0 = 5;
int s = 12909;
int n1;
string n = Console.ReadLine();
n1 = int.Parse(n);
if (n1> 1) 
    double an = (s / n1 * 2) - a0;
    double d = (s / n1 * 2 - 2 * a0) / (n1 - 1);
    Console.WriteLine(an);
    Console.WriteLine(d);


