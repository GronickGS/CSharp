using System;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double BASE, ALTURA, RESUL;
      
            Console.Write("DIGITE LA BASE :"); 
            BASE = double.Parse(Console.ReadLine());
            Console.Write("DIGITE LA ALTURA:"); 
            ALTURA = double.Parse(Console.ReadLine());
            RESUL = (BASE * ALTURA) / 2;
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:####.00}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:c}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:f}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:g}", RESUL));
            Console.WriteLine();
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:F}", DateTime.Now));
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:dddd}{0:dd/MM/yyy}", DateTime.Now));
            Console.Write("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}