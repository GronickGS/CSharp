using System;

namespace InveritNumeroDeTresCifras
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM, AUX, DEC, UNI, CEN;
            Console.WriteLine("INGRESE NÚMERO DE TRES CIFRAS :");
            NUM = int.Parse(Console.ReadLine());
            CEN = NUM / 100;
            NUM = NUM % 100;
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 100) + (DEC * 10) + CEN;
            Console.WriteLine("NÚMERO INVERTIDO ES: " + AUX);
            Console.WriteLine("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}