namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] codigos = { 511, 512, 153, 564, 125, 515 };
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
