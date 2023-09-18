using System;

namespace mayorDeTresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            byte MAY, MEN, NUM1, NUM2, NUM3;
            Console.Write("NÚMERO 1 :"); 
            NUM1 = byte.Parse(Console.ReadLine());
            Console.Write("NÚMERO 2 :");
            NUM2 = byte.Parse(Console.ReadLine());
            Console.Write("NÚMERO 3 :"); 
            NUM3 = byte.Parse(Console.ReadLine());
            MAY = NUM1; MEN = NUM1;
            if ((NUM2 > MAY)) MAY = NUM2;
            if ((NUM3 > MAY)) MAY = NUM3;
            if ((NUM2 > MEN)) MEN = NUM2;
            if ((NUM3 < MEN)) MEN = NUM3;
            Console.WriteLine("MAYOR ES:" + MAY);
            Console.WriteLine("MENOR ES:" + MEN);
            Console.WriteLine("Pulse una tecla para terminar"); Console.ReadLine();
        }
    }
}