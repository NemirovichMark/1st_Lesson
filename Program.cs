
//Task 1
double weight = 61.2;
double height = 1.72;
double index = weight/(height*height);
Console.WriteLine($"MY BMI = {Math.Round(index, 1)}"); //rounding a number to 1 decimal place

//Task 2
double a = 100 % 12.0; //due to the fact that my group number is 20 (a = 0), I took 12 for a normal answer
double b = 18 - (a / 20.0);
double grad = 10 * 20.0;
const double Pi = 3.14;
double p = 4 * ((Pi * a * b + (a - b)) / (a + b));  //perimeter of an ellipse
double length = p / 360 * grad;  // the ellipse sector formula 
Console.WriteLine($"The length of the ellipse sector = {Math.Round(length,5)}");

//Task 3
using System.ComponentModel.DataAnnotations;
int a0 = 20;
int S = 12612;
Console.WriteLine("Enter the number of elements in an Arithmetic Sequence: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n != 0 && n > 0)
{
    var an = ((2 * S) / n) - a0; //consequence of the sum formula
    var d = ((2 * S / n) - 2 * a0) / (n - 1); //using the sum formula to find the progression step
    Console.WriteLine($"The step: {d} The nth term of an Arithmetic Sequence: {an}");
}
else Console.WriteLine("Error");

