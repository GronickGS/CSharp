using System;

namespace mayorDeDosNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2;
            Console.Write("NÚMERO 1 :"); 
            NUM1 = int.Parse(Console.ReadLine());
            Console.Write("NÚMERO 2 :");
            NUM2 = int.Parse(Console.ReadLine());
            if ((NUM1 > NUM2))
            {
                Console.WriteLine("{0} ES MAYOR QUE {1}", NUM1, NUM2);
            }
            else
            {
                if ((NUM1 == NUM2))
                {
                    Console.WriteLine("{0} ES IGUAL A {1}", NUM1, NUM2);
                }
                else
                {
                    Console.WriteLine("{0} ES MENOR QUE {1}", NUM1, NUM2);
                }
            }
            Console.WriteLine();
            Console.WriteLine("OTRA MANERA");
            string RESUL;
            if (NUM1 > NUM2)
            {
                RESUL = "MAYOR";
            }
            else
            if (NUM1 == NUM2)
            {
                RESUL = "IGUAL";
            }
            else
            {
                RESUL = "MENOR";
            }
            Console.WriteLine("{0} ES {1} QUE {2}", NUM1, RESUL, NUM2);
            Console.Write("Pulse una tecla para terminar"); Console.ReadLine();
        }
    }
}