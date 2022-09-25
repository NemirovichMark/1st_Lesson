using System;

public class Proga
{
    public static double FACTORIAL(double a)
    {
        double fff = 1;
        for (double i = 1; i <= a; i += 1)
        {
            fff *= i;
        }
        return fff;
    }

    public static void Main(string[] args)
    {
        #region 1lvl_ex4
        Console.WriteLine("Eneter x");
        double x, otv = 0;
        x = Convert.ToDouble(Console.ReadLine()); // считал что Х будет значение в градусах
        while (x == 0)
        {
            Console.WriteLine("Please enter x not 0");
            x = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 1; i <= 9; i += 1)
        {
            double angl = Math.PI * (x) / 180;
            otv += Math.Cos(angl * i) / Math.Pow(x, i - 1);
        }
        Console.WriteLine(otv);
        #endregion


        #region 1lvl_ex9
        double otv1 = 0;
        for (double i = 1; i <= 6; i += 1)
        {
            otv1 += Math.Pow(-1, i) * Math.Pow(5, i) / Proga.FACTORIAL(i);
        }
        Console.WriteLine(otv1);
        #endregion


        #region 1lvl_ex15
        double chisl = 1, znam = 1;
        for (double i = 0; i < 5; i += 1)
        {
            chisl = chisl + znam;
            znam += 1;
        }
        #endregion


        #region 1lvl_ex16
        double otv3 = 0;
        for (double i = 0; i < 64; i += 1)
        {
            otv3 += Math.Pow(2, i);
        }
        Console.WriteLine($"Amoun of seed is {otv3 / 15000} kg");

        #endregion


        #region 1lvl_ex18
        for (double i = 1; i <= 8; i += 1)
        {
            Console.WriteLine($"After {i * 3} hours amount of amoebas wiil be {10 * Math.Pow(2, i)}");
        }
        #endregion


        #region 2lvl_ex2
        double L = 1, mnoj = 1;
        while (L <= 29)
        {
            L *= mnoj;
            mnoj += 3;
        }
        Console.WriteLine(mnoj - 6);
        #endregion


        #region 2lvl_ex4
        double E = 1, stepen = 2, x1;
        Console.WriteLine("Eneter 1 < x < 1");
        x1 = Convert.ToDouble(Console.ReadLine());
        while (Math.Pow(x1, stepen) >= 0.0001)
        {
            E += Math.Pow(x1, stepen);
            stepen *= 2;
        }
        Console.WriteLine(E);
        #endregion


        #region 2lvl_ex7-8
        double way = 10, A = 0, B = 10, C = 10, hod = 0;
        for (double i = 0; i < 7; i += 1)
        {
            A += way * Math.Pow(1.1, i);
        }
        Console.WriteLine(A);

        while (B < 100)
        {
            B += way * Math.Pow(1.1, hod);
            hod += 1;
        }
        Console.WriteLine(hod + 1);

        hod = 0;
        while (way * Math.Pow(1.1, hod) <= 10)
        {
            C += way * Math.Pow(1.1, hod);
            hod += 1;
        }
        Console.WriteLine(hod + 1);
        #endregion


        #region 3lvl_ex1 
        double sum = 0, posl = 0;

        for (double xx = 0.1; xx <= 1; xx += 0.1)
        {
            for (double i = 0; ; i += 1)
            {
                posl = Math.Pow(-1, i) * (Math.Pow(xx, i)) / (FACTORIAL(Math.Pow(2, i)));

                if (posl < 0.0001)
                {
                    Console.WriteLine($"Sum is {sum} y is {Math.Cos(xx)}");
                    break;
                }
                sum += posl;
            }
            if (posl < 0.0001)
            {
                break;
            }
        }
        #endregion



        #region 3lvl_ex3
        double suma = 0, posla = 0;

        for (double xx22 = 0.1; xx22 <= 1; xx22 += 0.1)
        {
            for (double i22 = 0; ; i22 += 1)
            {
                posla = Math.Cos(Math.PI * i22) / FACTORIAL(i22);
                if (posla < 0.0001)
                {
                    Console.WriteLine($"Sum is {suma} y is {Math.Pow(Math.E, Math.Cos(xx22)) * Math.Cos(Math.Sin(xx22))}");
                    return;
                }
                suma += posla;
            }
        }
        #endregion
    }
}
