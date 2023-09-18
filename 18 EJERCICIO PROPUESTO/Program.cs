//  Concepto:
//  Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal,
//  una cifra numérica o una consonante (pista: habrá que usar un dato de tipo "char").

using System;

namespace ejercicio_propuesto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char TECLA;
            Console.Write("DIGITE UNA SOLA TECLA");
            Console.WriteLine();

            TECLA = char.Parse(Console.ReadLine());
            switch (TECLA)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    ; Console.WriteLine("ES UNA CIFRA NUMERICA");
                    break;
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    ; Console.WriteLine("ES UNA VOCAL");
                    break;
                default:
                    Console.WriteLine("ES UNA CONSONANTE");
                    break;
            }
            Console.Write("Pulse una tecla para terminar"); Console.ReadLine();
        }
    }
}