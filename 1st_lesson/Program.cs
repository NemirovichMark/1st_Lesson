

             //1. Find your BMI - body mass index         
#region Task 1
Console.Write("Enter your weight: ");
int Weight;
Int32.TryParse(Console.ReadLine(), out Weight);
Console.Write("Enter your height: ");
int Height;
Int32.TryParse(Console.ReadLine(), out Height);
if(Height != 0 && Weight != 0) double BMI = (Weight / (Height * Height));
Console.WriteLine($"Your BMI: {BMI}");
#endregion


//             2.Find the length of the ellipse sector curve with:
//             a = 100 % (№ in the group)
//             b = age - (a / № in the group)
//             grad = 10 * (№ in the group)
#region Task 2
double A = 100 % 11;
double B = 19 - (A / 11);
int Grad = 10 * 11;
double Result, Thelengthofthecurve;
Thelengthofthecurve = 4 * ((Math.PI * A * B) + Math.Pow(A - B, 2)) / (A + B);
Result = Thelengthofthecurve / 360 * Grad;
Console.WriteLine($"The length of the ellipse curve: {Thelengthofthecurve}");
#endregion


//             3.Find the step(d) and nth term of an Arithmetic Sequence when:
//             a0 = (№ in the group)
//             S = 1ddmm of your birth day
#region Task 3
int A0 = 11;
int S = 1203;
int N;
Int32.TryParse(Console.ReadLine(), out N);
double An = (2 * S / N) - A0;
double D = (An - A0) / (N - 1);
Console.WriteLine($"Step: {D}. nth term: {An}");
#endregion