using System;

namespace SUMA_DE_N_NÚMEROS
{
    class Program
    {
        static void Main(string[] args)
        {
            byte CAN, K;
            int NUM;
            int SUM = 0;
            Console.Write("SUMA_DE_N_NÚMEROS");
            Console.Write("LÍMITE: ");
            CAN = byte.Parse(Console.ReadLine());
            for (K = 1; K <= CAN; K++)
            {
                Console.Write("DIGITE UN NÚMERO:"); 
                NUM = int.Parse(Console.ReadLine());
                SUM += NUM;
            }
            Console.WriteLine("SUMA TOTAL ES : " + SUM);
            Console.WriteLine("MEDIA ARITMÉTICA: " + SUM / CAN);
            Console.Write("Pulse una tecla para terminar"); Console.ReadLine();
        }
    }
}