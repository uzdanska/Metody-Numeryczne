using System;

namespace metoda_bisekcji
{
    class Program
    {
        private static void RownanieNieLiniowe(double a, double b, double e)
        {
            double xsr = (a + b) / 2;
            int i = 0;
            if (f(a) * f(b) < 0)
            {
                while (Math.Abs(f(xsr)) > e)
                { 
                    xsr = (a + b) / 2;
                    if (f(xsr) * f(a) > 0)
                    {
                        a = xsr;
                        i++;
                        Console.WriteLine("Iteracja nr " + i + ". W nowym przedziale [" + Math.Round(a, 6) + "," + Math.Round(b, 6) + "] wartosc funkcji f(" + Math.Round(a, 6) + ") wynosi : " + Math.Round(f(a), 6));
                    }
                    else
                    {
                        b = xsr;
                        i++;
                        Console.WriteLine("Iteracja nr " + i + ". W nowym przedziale [" + Math.Round(a, 6) + "," + Math.Round(b, 6) + "] wartosc funkcji f(" + Math.Round(b, 6) + ") wynosi : " + Math.Round(f(b), 6));
                    }
                }
            }
            else
            {
                Console.WriteLine("Warunek konieczny nie jest spełniony");
            }
        }
        private static double f(double x)
        {
            return(Math.Pow(x, 2) + 4.1 * x - 9);
        }
        static void Main(string[] args)
        {
            RownanieNieLiniowe(-10, -3, 0.01);
        }
    }
}

