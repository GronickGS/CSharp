using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace TABLA_DE_MULTIPLICAR
{
    class Program
    {
        static void Main(string[] args)
        {
            byte NUM, I;
            int RESUL;
            Console.Write("TABLA DE MULTIPLICAR"); 
            Console.Write("\nDIGITE NÚMERO: "); 
            NUM = byte.Parse(Console.ReadLine());
            for (I = 1; I <= 12; I++)
            {
                RESUL = NUM * I;
                Console.WriteLine("{0} * {1} = {2}", NUM, I, RESUL);
            }
            Console.Write("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}