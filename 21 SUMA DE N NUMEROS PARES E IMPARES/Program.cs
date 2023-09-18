using System;

namespace SUMA_DE_N_NÚMEROS_PARES_E_IMPARES
{
    class Program
    {
        static void Main(string[] args)
        {
            byte NUM, I;
            int SUMP = 0;
            int SUMI = 0;
            Console.Write("SUMA_DE_N_NÚMEROS_PARES_E_IMPARES");
            Console.Write("\nNÚMERO MÁXIMO: ");
            NUM = byte.Parse(Console.ReadLine());
            for (I = 1; I <= NUM; I += 2)
            {
                SUMP = SUMP + I;
            }
            for (I = 2; I <= NUM; I += 2)
            {
                SUMI = SUMI + I;
            }
            Console.WriteLine("TOTAL EN PARES : " + SUMP);
            Console.WriteLine("TOTAL EN IMPARES : " + SUMI);
            Console.Write("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}
