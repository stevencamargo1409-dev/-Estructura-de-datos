using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp
{
    internal class Program
    {
        static void ImprimirCabezera(
            string Materia, 
            int Grupo, 
            string Nombre, 
            string Apellido, 
            string Matricula, 
            string Fecha, 
            string Hora)     
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("         UNIVERSIDAD DEL CARIBE            ");
            Console.WriteLine($" Nombre: {Nombre}");
            Console.Writeline($"Apellido: {Apellido}");
            Console.WriteLine($" Matrícula : {Matricula}");
            Console.WriteLine($" Materia: {NombreMateria}");
            Console.WriteLine($" Grupo: {Grupo}");
            Console.WriteLine($" Fecha: {Fecha}");
            Console.WriteLine($" Hora : {Hora}");
            Console.WriteLine("===========================================");
        }

        public static void Main(string[] args) 
        {
            
            ImprimirCabezera(
                "Fundamentos de Programación", 1,"Steven","De León","2026-0145","21/08/2026","01:30 PM");
            
        }
    }
}using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pp
{
    internal class Program
    {
        static void ImprimirCabezera(
            string Materia, 
            int Grupo, 
            string Nombre, 
            string Apellido, 
            string Matricula, 
            string Fecha, 
            string Hora)     
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("         UNIVERSIDAD DEL CARIBE            ");
            Console.WriteLine($" Nombre: {Nombre}");
            Console.Writeline($"Apellido: {Apellido}");
            Console.WriteLine($" Matrícula : {Matricula}");
            Console.WriteLine($" Materia: {NombreMateria}");
            Console.WriteLine($" Grupo: {Grupo}");
            Console.WriteLine($" Fecha: {Fecha}");
            Console.WriteLine($" Hora : {Hora}");
            Console.WriteLine("===========================================");
        }

        public static void Main(string[] args) 
        {
            
            ImprimirCabezera(
                "Fundamentos de Programación", 1,"Steven","De León","2026-0145","21/08/2026","01:30 PM");
            
        }
    }
}
