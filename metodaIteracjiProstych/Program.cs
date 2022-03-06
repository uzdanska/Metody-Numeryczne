using System;

namespace metodaIteracjiProstych
{
    class Program
    {
         public const int N = 3;
        static void Main(string[] args)
        {
            double[,] macierz= new double[N, N] {
                {3, 1, 2}, 
                {1, -4, 1}, 
                {1, 2, 3}
            };
            double[] y = new double[N] {
                5, 
                -7, 
                2
            };
            double[] x = new double [N];
            double[] xi = new double [N];
            double[] g = new double[N];
            double[,] h = new double[N, N];
            double e = 0.000000001;
  
            for(int i = 0 ; i < y.Length; i++)
            {
                g[i] =   y[i]/macierz[i,i];
                Console.WriteLine($"g[{i}] = {g[i]}");
                for(int j = 0; j < y.Length; j++)
                {
                    if(j == i)
                    {
                        h[i,j] = 0;
                        Console.WriteLine($"h[{i}, {j}] = {h[i,j]}");
                    }
                    else
                    {
                        h[i,j] = - macierz[i,j] / macierz[i,i];
                        Console.WriteLine($"h[{i}, {j}] = {h[i,j]}");
                    } 
                }
            }
            for(int i = 0 ;i < 3; i++)
            {
                
                if(i==0)
                {
                    Console.WriteLine($"Przybliżenie {i+2}");
                    x[i] = g[i] + h[i,i+1] * g[i+1] + h[i,i+2] * g[i+2];
                    Console.WriteLine($"x[{i}] = {x[i]}");
                }
                else if( i == 1)
                {
                    x[i] = g[i] + h[i, i-1] * g[i-1] + h[i,i+1] * g[i+1];
                    Console.WriteLine($"x[{i}] = {x[i]}");
                }
               else{
                   x[i] = g[i] +h[i, i-1] * g[i-1] +h[i, i-2] * g[i-2];
                   Console.WriteLine($"x[{i}] = {x[i]}");
               }
            }
            int l = 2;
            do
            {
                xi[0] = x[0] ; xi[1] = x[1]; xi[2] = x[2];
                    Console.WriteLine(xi[0]+ ", " +xi[1] + ", " +xi[2]);
                    l++;
                 for(int i = 0 ;i < 3; i++)
                {
                    
                    if(i==0)
                    {
                        Console.WriteLine($"Przybliżenie {l}");
                        x[i] = Math.Round(g[i] + h[i,i+1] * xi[i+1] + h[i,i+2] * xi[i+2],5);
                        Console.WriteLine($"x[{i}] = {x[i]}");
                    }
                    else if( i == 1)
                    {
                        x[i] = Math.Round(g[i] + h[i, i-1] * xi[i-1] + h[i,i+1] * xi[i+1],5);
                        Console.WriteLine($"x[{i}] = {x[i]}");
                    }
                    else{
                        x[i] = Math.Round(g[i] +h[i, i-1] * xi[i-1] +h[i, i-2] * xi[i-2],5);
                        Console.WriteLine($"x[{i}] = {x[i]}");
                    }
                }
            }while(Math.Abs(x[0] - xi[0]) > e &&Math.Abs(x[1] - xi[1]) > e  &&Math.Abs(x[2] - xi[2]) > e  );

        }
    }
}

