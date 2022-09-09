using System;

namespace _1st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Integers
            int a, b = 5;
            int c;
            int d = 10;

            // just for info
            short smallIntegers = Int16.MaxValue;
            long outstretchedInteger = Int64.MinValue;
            uint notNegativeIntegers = 5;   // not negative
            byte FF = 255;                  // not sigative
            sbyte ff = -127;                // signed (+-) byte


            a = (b / 5) + d%4 - 2; // при делении целых чисел всегда округляется вниз
            c = -123546;

            // Используйте интерполированные строки ($) для вывода и будет вам счастье
            Console.WriteLine($"Integers: a={a}, b={b}, c={c}, d={d}");
            #endregion

            #region Doubles
            double aa, bb = 5.0;
            double cc;
            double dd = 12.251;

            float f = 123.4f;
            decimal m = 123.4m;

            aa = (bb / 5) + dd % 4 - 2; // тут проблем с округлением не будет
            cc = b / 5.0; // важно, чтобы 1 из чисел было дробным, тогда будет довольно точный расчет
            
            Console.WriteLine($"Doubles: aa={aa}, bb={bb}, cc={cc}, dd={dd}");
            #endregion

            #region Strings
            string s = "", str = string.Empty; // 2 пустые строки
            string name = "Vasya";
            string famile = "P" + "u" + "p" + "kin"; // не делайте так! Тут строка пересоздается 4 раза.

            Console.WriteLine(name + " " + famile + " cool guy =)");
            #endregion

            #region Chars
            char letter = 'a';
            char digit = '0';
            char symbol = '+';

            Console.WriteLine($"Zero is " + digit); 
            // тут идет преобразование символа в строку, так как строка - это набор символов
            #endregion
 
                
            #region Booleans
            bool t = true, f;
            f = false;
            t = 5 > 2;
            t = (1 == 0) || ((1 > 0) && true);
            f = !t;

            Console.WriteLine($"True is {t,10}. false is {f,-10}"); 
            #endregion

            Console.WriteLine($"Zero is " + digit); 
            // тут идет преобразование символа в строку, так как строка - это набор символов
            #endregion

            #region Casting and type conversion
            #region Implicit Conversions
            aa = a;
            b = 5;
            bb = 5;
            #endregion

            #region Explicit conversions (casts)
            //a = aa;
            a = (int)aa; // Cast double to int. Приведение дробного к целому.
            bb = (double)b; // Нет смысла из подмножества приводить к множеству double > int
            #endregion

            #region Сonversions by methods
            s = a.ToString();
            str = aa.ToString();

            a = Int32.Parse("123");
           // bb = Double.Parse("Hey, are you ready to errors?");
            #endregion

            // Полная таблица явных и неявных преобразований, если заинтересовало (будет полезно):
            // https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/numeric-conversions
            #endregion

            #region TryCatchFinally
            // How to avoid errors?
            int divizionByZero = 50;
            try
            {
                // this block have to be
                a = 0; 
                divizionByZero = divizionByZero / a;
            }
            catch
            {
                //throw new DivideByZeroException();
            }
            finally
            {
                Console.WriteLine("Would a == 0 or not, this block would work");
                Console.WriteLine(divizionByZero);
            }

            #region TryMethods
            if (Int32.TryParse(str, out int numberFromString))
            {
                divizionByZero /= numberFromString;
            }
            #endregion

            #endregion

            #region Math class
            a = (int)Math.Pow(5, 2);
            bb = Math.Sin(aa); // Угол, измеряемый в радианах.
            c = Math.Abs(c);
            #endregion

            #region First example
            // Find the roots of the equation

            // 3.2x + 8.7x^2 = 17.9 

            aa = 8.7;
            bb = 3.2;
            cc = -17.9;

            double discriminant = Math.Pow(bb, 2) - 4 * aa * cc;
            try
            {
                double x1 = (-bb + Math.Sqrt(discriminant)) / 2 * aa;
                double x2 = (-bb - Math.Sqrt(discriminant)) / 2 * aa;

                Console.WriteLine($"Roots of the eqution are: {x1, 5} and {x2, 5}");
            }
            catch
            {
                Console.WriteLine("There is no rational roots");
            }
            #endregion

            #region Second example
            // Find the value of f(x) when x is...
            // f(x) = 25.3x + lg(4|x|+50) - exp^(x/100)
            Console.WriteLine("Type the integer x");
            if(Int32.TryParse(Console.ReadLine(), out int x))
            { 
                aa = 25.3 * x;
                bb = Math.Log10(4 * Math.Abs(x) + 50);
                cc = Math.Exp(x / 100);
                var y = aa + bb - cc; // var используйте, когда справа написан тип или вам подойдет любой принимаемый тип
                Console.WriteLine($"The f({x}) = {y}");
            }
            #endregion

            /* Tasks:
             * 1. Find your BMI - body mass index
             * 
             * 2. Find the length of the ellipse sector curve with:
             *  a = 100 % (№ in the group)
             *  b = age - (a / № in the group)
             *  grad = 10 * (№ in the group)
             * 
             * 3. Find the step (d) and nth term of an Arithmetic Sequence when:
             *  a0 = (№ in the group)
             *  S = 1ddmm of your birth day
             */
                
            #region First Task
            const double height = 1.58;
            const double weight = 47;
            double BMI;
            BMI = weight / (height * height);
            Console.WriteLine(BMI);
            #endregion

            #region Second Task
            const double a = 100 % 6;
            const double b = 19 - (a / 6);
            const int grad = 10 * 6;
            double result_All, result;
            result_All = 4* (Math.PI *a*b+ (a - b)*(a-b))/(a+b);
            result = result_All / 360 * grad;

            Console.WriteLine(result);

            #endregion

            #region
            const int a0 = 6;
            const int s = 10508;
            int n = Int32.Parse(Console.ReadLine());
            int a_n = s / n * 2 - a0;
            double stepB = (a_n - a0) / n;
            Console.WriteLine(b);
            #endregion
        }
    }
}
