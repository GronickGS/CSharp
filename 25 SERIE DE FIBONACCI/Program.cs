using System;

namespace SERIE_DE_FIBONACCI
{
    class Program
    {
        static void Main(string[] args)
        {
            byte CAN, K;
            int A, B, C;
            Console.Write("CUANTOS NÚMEROS: ");
            CAN = byte.Parse(Console.ReadLine());
            A = 1; B = 1;
            Console.Write(A + " " + B + " ");
            for (K = 3; K <= CAN; K++)
            {
                C = A + B;
                Console.Write(C + " ");
                //INTERCAMBIO DE VALORES
                A = B;
                B = C;
            }
            Console.WriteLine();
            Console.Write("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}