using System;

namespace numeroIntermedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, NUM3;
            Console.Write("PRIMER NÚMERO :"); 
            NUM1 = int.Parse(Console.ReadLine());
            Console.Write("SEGUNDO NÚMERO :"); 
            NUM2 = int.Parse(Console.ReadLine());
            Console.Write("TERCER NÚMERO :"); 
            NUM3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("EL INTERMEDIO ES: ");
            if ((NUM1 > NUM2))
            {
                if ((NUM1 < NUM3))
                {
                    Console.WriteLine(NUM1);
                }
                else
                {
                    if ((NUM2 < NUM3))
                    {
                        Console.WriteLine(NUM3);
                    }
                    else
                    {
                        Console.WriteLine(NUM2);
                    }
                }
            }
            else
            {
                if ((NUM2 < NUM3))
                {
                    Console.WriteLine(NUM2);
                }
                else
                {
                    if ((NUM1 < NUM3))
                    {
                        Console.WriteLine(NUM3);
                    }
                    else
                    {
                        Console.WriteLine(NUM1);
                    }
                }
            }
            Console.Write("Pulse una tecla para terminar"); Console.ReadLine();
        }
    }
}