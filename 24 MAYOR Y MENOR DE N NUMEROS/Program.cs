using System;

namespace mayor_y_menor_n_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            byte CAN, K;
            int MAY, MEN, NUM;

            Console.Write("LÍMITE:");
            CAN = byte.Parse(Console.ReadLine());
            Console.Write("DIGITE UN NÚMERO:"); 
            MAY = int.Parse(Console.ReadLine());
            MEN = MAY;
            for (K = 2; K <= CAN; K++)
            {
                Console.Write("DIGITE UN NÚMERO:"); 
                NUM = int.Parse(Console.ReadLine());
                if (NUM > MAY) MAY = NUM;
                if (NUM < MEN) MEN = NUM;
            }
            Console.WriteLine("EL MAYOR ES : " + MAY);
            Console.WriteLine("EL MENOR ES : " + MEN);
            Console.WriteLine("DIFERENCIA ES : " + (MAY - MEN));
            Console.Write("Pulse una tecla para terminar"); Console.ReadLine();
        }
    }
}