using System;

namespace metodaSimpsona
{
    class Program
    {
        private static void metodaSimpsona(double p, double k , int n)
        {
            double[] x = new double[n + 1];
            double[] t = new double[n];
            x[0] = p;
            x[n] = k;
            double suma = f(x[0]) + f(x[n]);
            double wynik = 0;
            Console.WriteLine("x[i]:  ");
            for(int i = 1; i < n; i++)
            {
                x[i] = p + (i/(double)n)*(k-p);
                Console.WriteLine($"{i}-ty punkt i wynosi: {x[i]}");
                Console.WriteLine( $"f({x[i]}) = {f(x[i])} ");
                suma += 2 * f(x[i]);
            }
            double h = (x[n] - x[n-1])/2;
            Console.WriteLine($"\nh = {Math.Round(h, 4)}");
            Console.WriteLine("\nt[i] : ");
            for(int i = 0; i < n; i++)
            {
                t[i] = (x[i+1] + x[i])/2;
                Console.WriteLine($"{i} -ty punkt i wynosi:   {t[i]}");
                Console.WriteLine($"f({t[i]}) = {f(t[i])} ");
                suma += 4 * f(t[i]);
            }
            wynik = suma * (h/3);
            Console.WriteLine("\nWynik wynosi = " + Math.Round(wynik, 7));
        }
        private static double f(double x)
        {
            return(Math.Sin(1.1*x - 0.3)/(2.5 + x*x));
        }
        static void Main(string[] args)
        {
           metodaSimpsona(1.4, 3.2, 3);
        }
    }
}
