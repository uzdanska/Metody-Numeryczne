using System;

namespace NewtonRP
{
    class Program
    {
        public static void rozniceProgresowe(double[] tabx, double[,] taby, int rzad)
        {
           
            for(int i = 0; i < tabx.Length - rzad; i++)
            {
                taby[rzad, i] = taby[rzad - 1, i+1] - taby[rzad-1, i];
                Console.WriteLine($"[{rzad} , {i}] wynosi : {taby[rzad, i]}");
            }
        }
        public static double Wielomiany(double[] tabx, double[,] taby, int rzad)
        {
            double wielomian = 0;
            if(rzad == 0)
            {
                wielomian = taby[rzad,0];
                return wielomian;
            }
            else{
                wielomian = taby[rzad,0]/(silnia(rzad) * Math.Pow(tabx[1] - tabx[0],rzad));
                return wielomian;
            }
        }
        public static void NewtonRP(double punkt, double[] tabX, double[,] tabY, int rzad)
        {
            double wielomian, wielomian1, wielomian2, wielomian3, wielomian4, wielomian5;
            do{
                rozniceProgresowe(tabX, tabY, rzad);                
                rzad++;
            }while(rzad <= tabX.Length);

            wielomian1 = Wielomiany(tabX, tabY, 0);
            wielomian2 = Wielomiany(tabX,tabY,  1)*(punkt - tabX[0]);
            wielomian3 = Wielomiany(tabX,tabY,  2)*(punkt - tabX[0])*(punkt - tabX[1]);
            wielomian4 = Wielomiany(tabX,tabY,  3) *(punkt - tabX[0])*(punkt - tabX[1])*(punkt - tabX[2]);
            wielomian5 = Wielomiany(tabX,tabY,  4) *(punkt - tabX[0])*(punkt - tabX[1])*(punkt - tabX[2])*(punkt - tabX[3]);
            wielomian = wielomian1 +  wielomian2 +wielomian3 +wielomian4 + wielomian5; 
               
            Console.WriteLine($"\nW punkcie: {punkt} wielomian ma rozwiązanie równe W({punkt}) = {wielomian1} + ({wielomian2}) + {wielomian3} + ({wielomian4}) + {wielomian5} = {wielomian}");
        }
        public static int silnia(int n)
        {
            int wynik;
            if(n <= 1)
            {
                wynik = 1;
            }
            else{
                wynik = n*silnia(n-1);
            }
            return wynik;
        }
        static void Main(string[] args)
        {   
            int rzad = 1;
            double punkt = 1;
            
            double[] tabX = {-4, -2, 0, 2 ,4};
            
            double[,] tabY = new double[tabX.Length, tabX.Length];
            
            tabY[0,0] = 1034;
            tabY[0, 1] = 56;
            tabY[0, 2] = -2;
            tabY[0,3] = 44;
            tabY[0, 4] = 914;
             Console.WriteLine("Różnice progresowe kolejnych rzędów: \n[rzad, indeks tablicy]");
            NewtonRP(punkt, tabX, tabY, rzad);
            
        }
    }
}
  