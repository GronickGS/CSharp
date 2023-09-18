//  Concepto:
//  Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Gronick", o bien le diga "No te conozco" si teclea otro nombre.
//  1. Abrir un nuevo Proyecto
//  2. Seleccione Aplicación de Consola

using System;

namespace Ejercicio_Propuesto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOMBRE;
            Console.Write("Ingrese su nombre : "); 
            NOMBRE = Console.ReadLine();

            if (NOMBRE == "Gronick")
            {
                Console.WriteLine();
                Console.WriteLine("HOLA");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("NO TE CONOZCO");
            }
            Console.WriteLine();
            Console.Write("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}