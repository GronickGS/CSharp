using System;

namespace CALIFICACIONES_DE_UN_GRUPO_DE_ESTUDIANTES
{
    class Program
    {
        static void Main(string[] args)
        {
            byte CAN, K;
            double NOTA1, NOTA2, PROM, SUM;
            string NOM;
            Console.Write("CUANTOS ESTUDIANTES: ");
            CAN = byte.Parse(Console.ReadLine());
            SUM = 0;
            for (K = 1; K <= CAN; K++)
            {
                Console.Write("NOMBRE: "); 
                NOM = Console.ReadLine();
                Console.Write("NOTA 1: ");
                NOTA1 = double.Parse(Console.ReadLine());
                Console.Write("NOTA 2: "); 
                NOTA2 = double.Parse(Console.ReadLine());
                PROM = (NOTA1 + NOTA2) / 2;
                Console.WriteLine("PROMEDIO: " + PROM);
                SUM += PROM;
            }
            Console.WriteLine();
            Console.WriteLine("SUMA TOTAL ES : " + SUM);
            Console.WriteLine("MEDIA ARITMÉTICA: " + SUM / CAN);
            Console.WriteLine("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}