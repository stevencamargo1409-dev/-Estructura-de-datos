using System;
using System.IO;
class Program
{
    static void Main()
    {
        string ruta = "productos.csv";
        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine("ID,Nombre,Precio,cantidad");
            sw.WriteLine("1,Laptop,1200,7");
            sw.WriteLine("2,Mouse,25,10");
            sw.WriteLine("3,Monitor,300,6");
            sw.WriteLine("4,auricular,150,12");
            sw.WriteLine("5,luces led,500,5");
            sw.WriteLine("6,silla gamer,3000,2");
            sw.WriteLine("7,microfono,120,9 ");
        }

        string[] lineas = File.ReadAllLines(ruta);
        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');
            double cantidad = double.Parse(campos[3]);
            if (cantidad > 10)
                Console.WriteLine($"{campos[1]} - ${cantidad}");
        }
    }
}
