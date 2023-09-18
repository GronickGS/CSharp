using System;

namespace libreriaMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1;
            long RESUL;
            Console.Write("DIGITE UN NÚMERO :");
  
            NUM1 = int.Parse(Console.ReadLine());
            RESUL = Math.Abs(NUM1);
            Console.WriteLine("VALOR ABSOLUTO : " + RESUL);
            Console.WriteLine("POTENCIA : " + Math.Pow(NUM1, 3));
            Console.WriteLine("RAIZ CUADRADA : " + Math.Sqrt(NUM1));
            Console.WriteLine("SENO : " + Math.Sin(NUM1 * Math.PI / 180));
            Console.WriteLine("COSENO : " + Math.Cos(NUM1 * Math.PI / 180));
            Console.WriteLine("NÚMERO MÁXIMO : " + Math.Max(NUM1, 50));
            Console.WriteLine("NÚMERO MÍNIMO : " + Math.Min(NUM1, 50));
            Console.WriteLine("PARTE ENTERA : " + Math.Truncate(18.78));
            Console.WriteLine("REDONDEO : " + Math.Round(18.78));
            Console.Write("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}