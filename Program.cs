﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task1
#region
Double ves = 53; 
Double rost = 170;
Double BMI = ves / (rost * rost);
Console.WriteLine("your bmi is " + BMI);
#endregion

//Task 2
#region
Double a = 100 % 3, b = 18 - (a / 3), grad = 10 * 3;
Double p = (Math.PI * a * b + (a - b)) / (a + b);
Double x = (p / 360) * grad;
Console.WriteLine(x);
#endregion

//Task 3
#region
const int a0 = 20, S = 11005;
int n = Convert.ToInt32(Console.ReadLine()); //Convert.ToInt32() переводит в int
Double d = (2 * (S - n * a0)) / n * (n - 1); 
Double nl = 2 * S /n - a0; 
Console.WriteLine(d);
#endregion

