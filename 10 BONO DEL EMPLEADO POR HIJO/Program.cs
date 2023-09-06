using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double SUELDO, ARECIBIR;
            int NHIJO, BONO;
            string NOM;
            Console.Write("NOMBRE EMPLEADO :"); 
            NOM = Console.ReadLine();
            Console.Write("SUELDO EMPLEADO :"); 
            SUELDO = double.Parse(Console.ReadLine());
            Console.Write("NÚMERO DE HIJOS :");
            NHIJO = int.Parse(Console.ReadLine());
            if (NHIJO >= 3) { BONO = NHIJO * 10; } else { BONO = NHIJO * 20; }
            ARECIBIR = SUELDO + BONO;
            Console.WriteLine("RECIBE :" + String.Format("{0:c}", ARECIBIR));
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}