#region1

internal class program
{
    private static void Main(string[] args)
    {
        double height = 1.75;
        double weight = 65;
        int bmi = (int)(weight / Math.Pow(height, 2));
        Console.Write("My bmi is ");
        Console.Write(bmi);
    }
}
#endregion


#region2
using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        double a = 100 % 3;
        double b = 18 - a / 3;
        double grad = 10 * 3;
        var a1 = Math.Pow(a * Math.Cos(grad), 2);
        var b1 = Math.Pow(b * Math.Sin(grad), 2);
        var grad1 = Math.Atan((a1 / b1) * Math.Tan(grad));
        var sin = Math.Pow(Math.Sin(grad1), 2);
        var cos = Math.Pow(Math.Cos(grad1), 2);
        var end = Math.Sqrt(a1 * sin + b1 * cos);
        Console.Write("The length of the ellipse sector curve ");
        Console.WriteLine(end);
    }
}
#endregion

#region3
internal class Program
{
    private static void Main(string[] args)
    {
        int a0 = 3;
        int S = 11606;
        if (int.TryParse(Console.ReadLine(), out int n)) ;
        {
            double an = (S / n) * 2 - a0;
            double d = (an - a0) / (n - 1);
            Console.Write("nth term of an Arithmetic Sequence is ");
            Console.WriteLine(an);
            Console.Write("The step is ");
            Console.WriteLine(d);
        }
    }
}
#endregion