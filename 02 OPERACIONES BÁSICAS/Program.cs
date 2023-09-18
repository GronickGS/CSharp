using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, RESUL;
            string dato1, dato2;
            Console.Write("PRIMER NÚMERO :");
            dato1 = Console.ReadLine();
            NUM1 = int.Parse(dato1);
            Console.Write("SEGUNDO NÚMERO :");
            dato2 = Console.ReadLine();
            NUM2 = int.Parse(dato2);

            
            Console.WriteLine();
            RESUL = NUM1 + NUM2;
            Console.WriteLine("LA SUMA ES {0}: ", RESUL);
            RESUL = NUM1 - NUM2;
            Console.WriteLine("LA RESTA ES: {0} - {1} = {2} ", NUM1, NUM2, RESUL);
            RESUL = NUM1 * NUM2;
            Console.WriteLine("LA MULTIPLICACIÓN ES: " + RESUL);
            RESUL = NUM1 / NUM2;
            Console.WriteLine("LA DIVISIÓN ES: " + RESUL);
            RESUL = NUM1 % NUM2;
            Console.WriteLine("EL RESIDUO ES: " + RESUL);
            Console.Write("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}