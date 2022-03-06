using System;


namespace metodaTrapezow
{
    class Program
    {

        //https://www.wolframalpha.com/widgets/view.jsp?id=40563c7ee6ef51c162833327f8a3880d
        // program do do sprawdzania wyników

        private static void MetodaTrapezow(double a, double b , int n)
        {
            double h = (b - a)/ n;
            Console.WriteLine($"wysokosc wynosi: {Math.Round(h, 3)}");
            double[] x = new double[n];
            for(int i = 1 ; i <= n - 1; i++)
            {
                x[i] = a + i/(double)n*(b-a); // rzutowanie
                Console.WriteLine($"{i}-ty punkt i wynosi: {x[i]}");
            }
            double suma = f(a)/2  + f(b)/2;
            for(int i = 1 ; i <= n - 1 ; i++)
            {
                suma += f(x[i]);
                Console.WriteLine( $"f({Math.Round(x[i], 3)}) = {Math.Round(f(x[i]), 7)} ");
            }
            double wynik = suma * h;
            Console.WriteLine("wynik wynosi: " + Math.Round(wynik, 7));
        }
       
        private static double f(double x)
        {
            return(Math.Sin(1.1*x - 0.3)/(2.5 + x*x));
        }
        
        static void Main(string[] args)
        {
            MetodaTrapezow(1.4, 3.2, 15);
        }
    }
}
