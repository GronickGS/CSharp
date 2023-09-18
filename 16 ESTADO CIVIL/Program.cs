using System;

namespace estado_civil
{
    class Program
    {
        static void Main(string[] args)
        {
            char ECIVIL;
            Console.Write("DIGITE C,S,V,D :");
            ECIVIL = char.Parse(Console.ReadLine());
            switch (ECIVIL)
            {
                case 'C':
                    ; Console.WriteLine("CASADO");
                    break;
                case 'S':
                    ; Console.WriteLine("SOLTERO");
                    break;
                case 'V':
                    ; Console.WriteLine("VIUDO");
                    break;
                case 'D':
                    ; Console.WriteLine("DIVORCIADO");
                    break;
                default:
                    Console.WriteLine("NO EXISTE");
                    break;
            }
            Console.Write("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}