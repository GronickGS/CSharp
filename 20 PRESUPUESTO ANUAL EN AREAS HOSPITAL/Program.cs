﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PRESUPUESTO_ANUAL_EN_AREAS_HOSPITAL
{
    class Program
    {
        static void Main(string[] args)
        {
            double CANP, TOT, PORC;
            string AREA;
            byte CAN, I;
            Console.Write("CUANTOS CALCULOS: "); 
            CAN = byte.Parse(Console.ReadLine());
            Console.Write("DIGITE TOTAL DEL PRESUPUESTO: ");
            CANP = double.Parse(Console.ReadLine());
            for (I = 1; I <= CAN; I++)
            {
                Console.Write("DIGITE ÁREA: "); 
                AREA = Console.ReadLine();
                switch (AREA.ToUpper())
                {
                    case "GINECOLOGIA":
                        ; PORC = 40;
                        break;
                    case "TRAUMATOLOGIA":
                        ; PORC = 30;
                        break;
                    case "PEDIATRIA":
                        ; PORC = 30;
                        break;
                    default:
                        PORC = 0;
                        break;
                }
                TOT = (CANP * PORC) / 100;
                Console.WriteLine(AREA + " RECIBE " + String.Format("{0:C}", TOT));
            }
            Console.Write("Pulse una tecla para terminar");
            Console.ReadLine();
        }
    }
}