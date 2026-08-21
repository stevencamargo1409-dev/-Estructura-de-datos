using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steven_camargo
{
    internal class Program
    {
        static double CalcularAreaCirculo(double radio)
        {

            const double PI = 3.141592;
            //ahora se realiza el calculo de la formula
            double area = PI * Math.Pow(radio, 2);
            return area;

        }
        static void Main(string[] args)
        {//aqui se configura para que sea tipo double igual a el proceso
            Console.WriteLine("ingrese el radio del circulo:");
                double r = Convert.ToDouble(Console.ReadLine());
            //esto es para que salga el resultado 
           double result = CalcularAreaCirculo(r);
            //aqui se muestra el resultado
            Console.WriteLine($"el area es : {result:F2}");
        }
    }
}
