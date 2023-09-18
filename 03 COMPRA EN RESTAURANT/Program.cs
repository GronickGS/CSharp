using System;
namespace compraRestaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            byte CANB, CANH, CANP;
            double APAGAR;
            const double PRECIOB = 0.8;
            const double PRECIOH = 2;
            const double PRECIOP = 1.2;

            Console.Write("CANTIDAD DE HAMBURGUESAS :");
            CANH = byte.Parse(Console.ReadLine());
            Console.Write("CANTIDAD DE PAPAS :"); 
            CANP = byte.Parse(Console.ReadLine());
            Console.Write("CANTIDAD DE BEBIDAS :");
            CANB = byte.Parse(Console.ReadLine());
            Console.WriteLine();

            APAGAR = (CANH * PRECIOH) + (CANP * PRECIOP) + (CANB * PRECIOB);
            Console.WriteLine("VALOR A PAGAR: " + APAGAR);
            Console.Write("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}