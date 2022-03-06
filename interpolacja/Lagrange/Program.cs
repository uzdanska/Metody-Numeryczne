using System;

namespace Lagrange
{
    class Program
    {
        public static double interpolacjaLagrange(double[] x, double[] y, double xx)
        {
            int n = x.Length - 1;
            double w = 0.0;
            double li;
            for (int i = 0; i <= n; i++)
            {
                li = 1.0;
                Console.WriteLine("wyniki dla " + i+ " wartosci w tabeli");
                for (int j = 0; j <= n; j++)
                {
                    if (i != j)
                    {
                        li = li * ((xx - x[j]) / (x[i] - x[j]));
                        Console.WriteLine(li);
                    }
                }
                w += li * y[i];
                Console.WriteLine("Oto wynik aktualny: " + w + "\n");
            }
            return w;
        }
        static void Main(string[] args)
        {
            
            double[] tab1x = { -4, -2, 0, 2, 4 };
            double[] tab1y = { 1034, 56, -2, 44, 914 };
            double xx1 = 1;
            Console.WriteLine("Końcowy wynik to: "+interpolacjaLagrange(tab1x, tab1y, xx1));
        }
    }
}
 