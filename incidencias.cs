using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;

//registro de incidencia de soporte tecnico utilizando archivos (.txt)
//1. Guarda en una lista de incidencias atendidas en un archivo de  texto (incidencias.txt)
//2. leer el archovo
//3. generara un reporte que cuenta cuantas incidencias hay por prioridad (Alta, Media, BAja)
//4. la estructura del archivo es: ID, NOMBRE, DESCFRIPION, PRORIDAD
//Ejemplo: '01'; 'steven andres','daño del pc','Alta'
namespace steven
{
    internal class Program
    {
        //C:\Users\Sala-1\Desktop
        //creado ruya para guardar incidencias.
        static string pathArchivo = "incidencias.txt";

        static void GuardarIncidencias(List<string[]> incidencias)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathArchivo, false))
                {
                    foreach (string[] incidencia in incidencias)
                    {

                        sw.WriteLine(incidencia);
                    }
                }

            }
            catch (IOException ex)
            {

                Console.WriteLine($"Error al ecribir el archivo: {ex.Message}");

            }

        }

        static List<string[]> LeerIncidencias()
        {

            List<string[]> incidencias = new List<string[]>();
            if (!File.Exists(pathArchivo))
            {
                Console.WriteLine("El Archivo no existe aún.");
                return incidencias;
            }
            try
            {
                string linea;
                using (StreamReader sr = new StreamReader(pathArchivo))
                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(linea))
                        {
                            string[] campos = linea.Split(';');
                            incidencias.Add(campos);
                        }
                    }
            }
            catch (Exception error)
            {
                Console.WriteLine($"Error a  eer el archivo {error.Message}");
            }
            return incidencias;
        }

        static void GenerarReporte(List<string[]> incidencias)
        {
            if (incidencias.Count == 0)
            {
                Console.WriteLine("No hay Incidencias para reportar.");
                return;
            }
            Dictionary<string, int> conteoPorPrioridad = new Dictionary<string, int>();

            foreach (string[] inc in incidencias)
            {
                if (inc.Length < 4) continue;
                string prioridad = inc[3];
                //'01'; 'steven andres','daño del pc','Alta'
                if (conteoPorPrioridad.ContainsKey(prioridad))
                {
                    conteoPorPrioridad[prioridad]++;

                }
                else
                    conteoPorPrioridad[prioridad] = 1;
            }

            Console.WriteLine("\n REPORTE DE INCIDENCIAS");
            Console.WriteLine($"total Atendidas: {incidencias.Count}");
            Console.WriteLine("Detalle por prioridad");
            foreach (var inc in conteoPorPrioridad)
            {
                Console.WriteLine($"\nPrioridad {inc.Key}: {inc.Value}");
            }
        }


        static void Main(string[] args)
        {

            List<string[]> incidenciasToday = new List<string[]>
            {
                new string[] {"1","Steven De Leon","No Imprime","Alta" },
                new string[] {"2","Diego Camargo","Olvidó Contraseña","Baja" },
                new string[] {"3","Eduardo García","Wifi Lento","Alta" },
                new string[] {"4","Dilan José","Pantalla Azul","Media" },
                new string[] {"5","Andrea Ramirez","PC No enciende","Alta" },
            };


            Console.WriteLine("REGISTRO DE INDIDENCIAS UNICARIBE");
            GuardarIncidencias(incidenciasToday);
            Console.WriteLine("\n ---Leyendo Incidencias Del Archivo---");
            List<string[]> incidenciasLeidas = LeerIncidencias();

            Console.WriteLine("\n LISTADO DE INCIDENCIAS LEÍDAS: ");
            Console.WriteLine($"{"ID",-4}{"Usuario",-15}{"Descripcion",-20}{"Prioridad",-10}");
            Console.WriteLine(new string('-', 55));

            foreach (string[] inc in incidenciasLeidas)
            {
                if (inc.Length < 4) continue;
                Console.WriteLine($"{inc[0],-4}{inc[1],-15} {inc[2],-20}{inc[3],-10}");

            }
            GenerarReporte(incidenciasLeidas);
            Console.WriteLine("\nPresione cuan quier tecla para salir");
            Console.ReadKey();

        }



    }
}


