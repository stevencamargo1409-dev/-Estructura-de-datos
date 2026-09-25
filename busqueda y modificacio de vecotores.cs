using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] codigos = new double[20]; // declaranod e imiciando
                                              //lectura/escritura de nuestrro vector
            Console.WriteLine("----Ingreso de codigos----");

            for (int i = 0; i < codigos.Length; i++)// se usa .Legth para que el ciclo fincione en base al numero de elmentos
            {
                Console.WriteLine($"Ingrese el codigo {i + 1}");//i + 1 por que empieza desde 0
                codigos[i] = Convert.ToDouble(Console.ReadLine());// toma los datos que ingrese el usuario y los guarda en el vector
            }
            Console.WriteLine($"Codigos actuales:{string.Join(",", codigos)}");
            Console.WriteLine("ingrese el codigo que desea actualizar:");
            int busqueda = Convert.ToInt32(Console.ReadLine());

            int indiceEncontrado = -1;

            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == busqueda)
                {
                    indiceEncontrado = i;
                    break;
                }

            }

            if (indiceEncontrado != -1)
            {
                Console.WriteLine("Ingrese el nuevo codigo: ");
                codigos[indiceEncontrado] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nVector actualizado:{string.Join(",", codigos)}");
            }
            else
            {
                Console.WriteLine("\nError: el codigo no existe en la BDD");
            }
            Console.WriteLine($"el valor del indice es:{indiceEncontrado}");

        }

    }
}
