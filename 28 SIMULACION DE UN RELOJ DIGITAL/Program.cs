using System;
using System.Threading; // Necesario para Thread.Sleep

namespace SIMULACIÓN_DE_UN_RELOJ_DIGITAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 5; // Ajusta la altura de la ventana para la salida del reloj
            byte H, M, S;

            Console.SetCursorPosition(15, 2);
            Console.Write("SIMULACIÓN DE UN RELOJ DIGITAL");

            for (H = 0; H <= 23; H++) // Cambia de 24 a 23 para representar horas válidas (0-23)
            {
                for (M = 0; M <= 59; M++)
                {
                    for (S = 0; S <= 59; S++)
                    {
                        Console.SetCursorPosition(20, 10);
                        Console.Write("{0:D2}:{1:D2}:{2:D2}", H, M, S);
                        Thread.Sleep(1000); // Pausa durante 1 segundo (1000 milisegundos)
                    }
                }
            }

            Console.SetCursorPosition(25, 15);
            Console.Write("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}
