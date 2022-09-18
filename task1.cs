internal class Program
{
    private static void Main(string[] args)
    {
        //task 1
        int myWeight = 68;
        double myHeight = 1.8;
        double BMI = myWeight / (myHeight * myHeight);
        Console.WriteLine(Math.Round(BMI, 2, MidpointRounding.AwayFromZero));//хз как округлять лучше, но пусть будет так
        
        //task 2
        int n = 3, age = 18;
        int a = 100 % n;
        double b = age - (a / n);
        int grad = 10 * n;
        double p = Math.PI * (double)(a + b) * Math.Sin((Math.PI / 180) * grad);
        Console.WriteLine(p);
        
        //task 3
        int a0 = n;
        int S = 13003;
        int q = Convert.ToInt32(Console.ReadLine());
        if (q > 0)
        {
            double Aq = 2 * S / q - a0;
            double d = (Aq - a0) / q;
            Console.WriteLine(d);
            Console.WriteLine(Aq);

        }
        else
        {
            Console.WriteLine("Incorrect (q)");
        }

    }
}
