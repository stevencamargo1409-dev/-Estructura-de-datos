namespace temoeraturad_de_dia_de_las_semana
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] temperaturas = new double[5]; // declaranod e imiciando
                                                   //lectura/escritura de nuestrro vector
            Console.WriteLine("----Ingreso de temperaturas----");

            for (int i = 0; i < temperaturas.Length; i++)// se usa .Legth para que el ciclo fincione en base al numero de elmentos
            {
                Console.WriteLine($"Ingrese la temperatura del dia {i + 1}");//i + 1 por que empieza desde 0
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());// toma los datos que ingrese el usuario y los guarda en el vector
            }

            double suma = 0;
            double maxT = temperaturas[0];
            double minT = temperaturas[0];

            foreach (double t in temperaturas)
            {
                suma += t;// es lo mismo que suma=suma + temp
                if (t > maxT) maxT = t;
                if (t < minT) minT = t;
            }

            double promedio = suma / temperaturas.Length;//la sumatoria de las temperaturas entre el tramaño del vector

            //salida de informacion 

            Console.WriteLine("\n---Reporte---");// \n es para un salto de linea
            Console.WriteLine($"Temperatura registradas: {string.Join(",", temperaturas)}");
            Console.WriteLine($"Temperaturas Promedio: {promedio:F2}°C");
            Console.WriteLine($"Temperatura minima: {minT}°C");
            Console.WriteLine($"Temperatura maxina:{maxT}°C");


        }
    }
}
