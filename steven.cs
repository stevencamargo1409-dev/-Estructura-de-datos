using System;
using System.IO;
class Program
{
    static void Main()
    {
        string ruta = "Unicaribe.csv";
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("Nombre,Edad,Nota");
            sw.WriteLine("Steven,18,3.2");
            sw.WriteLine("Diego,24,4.0");
            sw.WriteLine("Camilo,19,3.5");
           
        }
         Console.WriteLine("Archivo creado exitosamente.");
    }
}
