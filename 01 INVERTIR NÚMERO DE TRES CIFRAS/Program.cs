using System;

namespace InvertirNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, AUX, DEC, UNI, CEN;

            Console.Write("INGRESE NÚMERO DE TRES CIFRAS: ");
            NUM = int.Parse(Console.ReadLine());

            CEN = NUM / 100;
            NUM = NUM % 100;
            DEC = NUM / 10;
            UNI = NUM % 10;

            AUX = (UNI * 100) + (DEC * 10) + CEN;

            Console.WriteLine("NÚMERO INVERTIDO ES: " + AUX);

            Console.WriteLine("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
