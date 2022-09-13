
double weight = 52.2;
double height = 1.7;
double BMI = weight / (height*height);
Console.WriteLine($"My BMI is {BMI}");
 //ex.2
int a = 100 % 13;
int b = 17 - (a % 13);
double grad = 13 * 100;
double pi = 3.1415;
double sec = (grad * 1) / 360;
double l = 2 * pi * Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)) / 2) / sec;
Console.WriteLine(l);
//ex.3
int a0 = 13;
int sum = 11710; 
int n = 2 * sum / sum + a0;
int d = 2 * (sum - n * a0) / n * (n - 1);
Console.WriteLine("Введите номер члена последовательности(от 2 до 15");
int an = Convert.ToInt32(Console.ReadLine());
int res = a0 + (an - 1)*d;
Console.WriteLine($"{an} член арифметической прогрессии равен {res}, а разность арифметической прогрессии равна {d}");
