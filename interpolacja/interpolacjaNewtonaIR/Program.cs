using System;

namespace interpolacjaNewtonaIR
{
    class Program
    {
        public static void ilorazyRoznicowe(double[] tabX, double[,] tabY, int rzad) 
        {
            for(int j = 0 ; j < tabX.Length - rzad; j++)
            {
                tabY[rzad, j] = (tabY[rzad - 1, j +1] - tabY[rzad - 1, j])/(tabX[j+rzad] - tabX[j]);
                Console.WriteLine($"[{rzad}, {j}] wynosi: {tabY[rzad, j]}");
            }
           
        }
        public static void NewtonIR(int punkt, double[] tabX, double[,] tabY, int rzad)
        {
            double wielomian;
            do{
                ilorazyRoznicowe(tabX, tabY, rzad);
                rzad++;
            }while(rzad < tabX.Length);
            wielomian = tabY[0, 0] +tabY[1, 0] * (punkt - tabX[0]) + tabY[2, 0] * (punkt - tabX[0]) * (punkt - tabX[1]) + 
                tabY[3, 0] * (punkt - tabX[0]) * (punkt - tabX[1]) * (punkt - tabX[2]) + 
                tabY[4, 0]* (punkt - tabX[0]) * (punkt - tabX[1]) * (punkt - tabX[2])*(punkt - tabX[3]);
            
            Console.WriteLine($"\nW punkcie: {punkt} wielomian ma rozwiązanie równe W({punkt}) = {wielomian}");
        }
        static void Main(string[] args)
        {
            int punkt = 1, rzad = 1;
    
            double[] tabX = {-4, -2, 0, 2 ,4};
            
            double[,] tabY = new double[tabX.Length, tabX.Length];
            
        
            tabY[0,0] = 1034;
            tabY[0, 1] = 56;
            tabY[0, 2] = -2;
            tabY[0,3] = 44;
            tabY[0, 4] = 914;
            
            Console.WriteLine("Ilorazy Różnicowe: \n[rzad, indeks tablicy]");
            NewtonIR(punkt, tabX, tabY, rzad);
        }
    }
}
