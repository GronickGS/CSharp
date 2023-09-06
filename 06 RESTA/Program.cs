using System;

namespace resta
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2;
            double RESUL;
            Console.Write("NÚMERO 1 :"); 
            NUM1 = int.Parse(Console.ReadLine());
            Console.Write("NÚMERO 2 :"); 
            NUM2 = int.Parse(Console.ReadLine());
            RESUL = (NUM1 + NUM2) * (NUM1 - NUM2);
            Console.WriteLine();
            Console.WriteLine("El resultado es : " + RESUL);
            Console.ReadLine();
        }
    }
}