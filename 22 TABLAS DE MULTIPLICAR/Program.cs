using System;

namespace TABLAS_DE_MULTIPLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, RESUL, T, I;
            Console.Write("TABLAS_DE_MULTIPLICAR");
            Console.Write("\nCUANTAS TABLAS: ");

            NUM = int.Parse(Console.ReadLine());
            for (T = 1; T <= NUM; T++)
            {
                for (I = 10; I >= 1; I--)
                {
                    RESUL = T * I;
                    Console.WriteLine("{0} * {1} = {2}", T, I, RESUL);
                }
                Console.Write("Pulse una tecla para terminar");
                Console.ReadLine();
            }
        }
    }
}