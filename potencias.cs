using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        //procedimiento suma e imprimir
        public static void ImprimirSuma(int a, int b)
        {


  
            int suma = a + b;
            Console.WriteLine(suma);

        }
         



         public static void MostrarPotencia(double num1,double pot )
         {
           double pote = Math.Pow(num1 , pot);
            Console.WriteLine($"la potencia de {num1} elevado a {pot} es:{pote}");


         }
        
     static void ModificarValor( int n)
     {
         n = n +1;
         Console.WriteLine($"Dentro del metodo: {n}");
         

     }

        
        static void Main(string[] args)
        {
            int x = 12 , y = 23 ;

            ImprimirSuma  (y,x);         //x,y             //(argumentos actuales) 
            ImprimirSuma  (1000, -1);   //1000,-1         //(argumentos literales)

            double num1 = 12, pot = 3;
            MostrarPotencia (num1, pot);

            
            int edad = 17;
            Console.WriteLine($"Antes del metodo: { edad}");
            ModificarValor (edad);
            Console.WriteLine($"Despues del metodo { edad}");
        }
