using System;

namespace sieczne
{
    class Program
    {
        //  rozne wartosci epislon i ilosc iteracji w kazdej metodzie (tabelka)
        // 25 stycznia
        // 1 lutego poprawa
        //  5 zadan
        // bledy 
        // interpolacje
        // calkowanie
        // aproksymacja
        // nieliniowe 
        //  (jedno narzucone)

        private static void sieczne(int a, int b, int n, double e)
        {
            double[] x = new double[n + 1];
            if(f(a) * f(b) < 0)
            {
                Console.WriteLine("Warunek konieczny spełniony");
                if(f(a) * fp2(a)> 0)
                {
                    NieruchomeA(a, n, b, e);
                }
                else
                {
                    NieruchomeB(a, n , b, e);
                }
            }
            else 
            {
                Console.WriteLine("Warunek konieczny nie jest spełniony");
            }
        }
        private static void NieruchomeA(int a, int n, int b, double e)
        {
            int j = 0;
            double[] x = new double[n + 1];
            x[0] = b;
            Console.WriteLine(x[0]);
            for(int i = 1; i <= n + 1; i ++)
            {
                x[i] = x[i-1] - f(x[i-1])/(f(x[i-1])- f(a)) *(x[i-1] - a);
                if(Math.Abs(f(Convert.ToDouble(x[i]))) < e)
                {
                    j++;
                    Console.WriteLine("Iteracja nr: " + j + " wynosi " + Math.Round(x[i],4));
                    break;
                }
                 else 
                {
                    j++;
                    Console.WriteLine("Iteracja nr: " + j + " wynosi " + Math.Round(x[i],4));
                }

            }
        }
        private static void NieruchomeB(int a, int n ,int b, double e)
        {
            int j = 0;
            double[] x = new double[n + 1];
            x[0] = a;
            Console.WriteLine(x[0]);
            for(int i = 1; i <= n + 1; i ++)
            {
                x[i] = x[i-1] - f(x[i-1])/(f(b)- f(x[i-1])) *(b - x[i-1]);
                if(Math.Abs(f(Convert.ToDouble(x[i]))) < e)
                {
                    j++;
                    Console.WriteLine("Iteracja nr: " + j + " wynosi " + Math.Round(x[i],4));
                    break;
                }
                else 
                {
                    j++;
                    Console.WriteLine("Iteracja nr: " + j + " wynosi " + Math.Round(x[i],4));
                }
            }
        }
        private static double f(double x)
        {
            return Math.Round(Math.Pow(x, 2) +  4.1 * x - 9, 4);
        }
        private static double fp1(double x)
        {
            return Math.Round(2 * x + 4.1, 4);
        }
        private static double fp2(double x)
        {
            return(2);
        }
        
        static void Main(string[] args)
        {
            sieczne(1, 2, 1000, 0.01);
        }
    }
}
