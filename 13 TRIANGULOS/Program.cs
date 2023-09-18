using System;

namespace triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            int LADO1, LADO2, LADO3;

            Console.Write("DIGITE LADO 1: ");
            
            LADO1 = int.Parse(Console.ReadLine());
            Console.Write("DIGITE LADO 2: ");
            LADO2 = int.Parse(Console.ReadLine());
            Console.Write("DIGITE LADO 3: ");
            LADO3 = int.Parse(Console.ReadLine());
            
            if ((LADO1 == LADO2) & (LADO2 == LADO3))
            {
                Console.WriteLine("TRIÁNGULO EQUILÁTERO. TODOS IGUALES");
            }
            else
            {
                if ((LADO1 != LADO2) & (LADO1 != LADO3) & (LADO2 != LADO3))
                {
                    Console.WriteLine("TRIÁNGULO ESCALENO. NINGUNO IGUAL");
                }
                else
                {
                    Console.WriteLine("TRIÁNGULO ISÓSCELES. DOS IGUALES");
                }
            }
            Console.Write("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}