﻿using System;

namespace desgloseDeBilletes
{
    class Program
    {
        static void Main(string[] args)
        {
            int CAN, C100, C50, C20, C10, C5;
            C100 = 0;
            C50 = 0;
            C20 = 0;
            C10 = 0;
            C5 = 0;
            Console.Write("DIGITE UNA CANTIDAD :");
            CAN = int.Parse(Console.ReadLine());
            if ((CAN >= 100))
            {
                C100 = (CAN / 100);
                CAN = CAN - (C100 * 100);
            }
            if ((CAN >= 50))
            {
                C50 = (CAN / 50);
                CAN = CAN - (C50 * 50);
            }
            if ((CAN >= 20))
            {
                C20 = (CAN / 20);
                CAN = CAN - (C20 * 20);
            }
            if ((CAN >= 10))
            {
                C10 = (CAN / 10);
                CAN = CAN - (C10 * 10);
            }
            if ((CAN >= 5))
            {
                C5 = (CAN / 5);
                CAN = CAN - (C5 * 5);
            }
            Console.WriteLine("BILLETES DE A 100: " + C100);
            Console.WriteLine("BILLETES DE A 50 : " + C50);
            Console.WriteLine("BILLETES DE A 20 : " + C20);
            Console.WriteLine("BILLETES DE A 10 : " + C10);
            Console.WriteLine("BILLETES DE A 5 : " + C5);
            Console.WriteLine("BILLETES DE A 1 : " + CAN);
            Console.Write("Pulse una tecla para terminar"); Console.ReadLine();
        }
    }
}