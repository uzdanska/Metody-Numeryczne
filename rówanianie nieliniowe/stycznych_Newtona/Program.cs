using System;

namespace stycznych_Newtona
{
    class Program
    {
        private static void  metodaStycznych(int a, int b, int n , double e)
        {
            if((f(a) * f(b) ) < 0)
            {
                if((fp1(a) * fp1(b)) >= 0 && (fp2(a) * fp2(b)) >= 0 )
                {
                    Console.WriteLine("Spelniony warunek zbieznosci");
                    warunekStopu(a, -b, n, e);
                }
                else 
                {
                    Console.WriteLine("Warunek zbieżności nie są spelniony");
                }
            }
            else 
            {
                Console.WriteLine("Warunek konieczny nie jest spelniony");
            }
        }
        private static void warunekStopu(int a, int b,int n, double e)
        {
            int j = 0;
            double[] x = new double[n + 1];
            x[0] = (f(a) * fp2(a) > 0) ? a : b;
            Console.WriteLine(x[0]);
            for(int i = 1 ; i <= n + 1  ; i++)
            {
                x[i] = x[i-1] - (f(x[i-1])/fp1(x[i-1]));
                if(Math.Abs(f(Convert.ToDouble(x[i]))) < e)
                {
                    j++;
                    Console.WriteLine("Iteracja nr: " + j + " wynosi " + Math.Round(x[i],4));
                    break;
                }
                else {        
                    j++;
                    Console.WriteLine("Iteracja nr: " + j + " wynosi " + x[i]);   
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
            metodaStycznych(-10, -3, 1000, 0.01);
        }
    }
}
