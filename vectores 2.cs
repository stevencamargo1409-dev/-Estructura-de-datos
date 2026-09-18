using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] Ventas = { 200.000, 302.300, 400.000, 300.233, 700.410, 740.432, 100.233, 99.423, 823.231, 902.211 };
            double Tot = 0;
            double Mayorv = Ventas[0];
            double MenorV = Ventas[0];
            int DMay = 0;
            int DMen = 0;


            for (int i = 0; i < Ventas.Length; i++)
            {
                Tot += Ventas[i];


                if (Ventas[i] > Mayorv)
                {
                    Mayorv = Ventas[i];
                    DMay = i;
                
                }
                if (Ventas[i] < MenorV)
                {
                    MenorV = Ventas[i];
                    DMen = i;
                }

            }
            double promedio = Tot / Ventas.Length;
            int diasSobrePromedio = 0;

            for (int i = 0; i < Ventas.Length; i++)
            {
                if (Ventas[i]> promedio)

                diasSobrePromedio++;
            }

            Console.WriteLine("=========== REPORTE DE VENTAS ============");
            Console.WriteLine();

            Console.WriteLine($"Total vendido: ${Tot:F3}.");
            Console.WriteLine($"Promedio diario: ${promedio}");
            Console.WriteLine();
            Console.WriteLine($"Mayor venta ${Mayorv:F3} el Dia {DMay + 1}");
            Console.WriteLine($"Menor Venta ${MenorV:F3} el Dia {DMen + 1}");

            Console.WriteLine($"Dias que superaron el promdio de ventas: ${diasSobrePromedio}");
            Console.WriteLine();

            for (int i = 0; i < Ventas.Length; i++)
            {
                Console.WriteLine($"Dia {i + 1}: ${Ventas[i]:F3}");
            }
        } 
    }
}
