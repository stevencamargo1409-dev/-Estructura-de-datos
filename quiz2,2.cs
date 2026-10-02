using System;

class Program
{
    static void Main()
    { int totalEstudiantes = 18;

        string[] nombres = new string[totalEstudiantes];
        double[] calificaciones = new double[totalEstudiantes];

        Console.WriteLine("calificaciones estudiantiles ");

        for (int i = 0; i < totalEstudiantes; i++)
        {
            Console.WriteLine($"\n Estudiante {i + 1} de {totalEstudiantes} ");

            for (bool nombreValido = false; !nombreValido; )
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                string ingresoNombre = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(ingresoNombre))
                {
                    nombres[i] = ingresoNombre.Trim();
                    nombreValido = true;
                }
                else
                {
                    Console.WriteLine("El nombre no puede estar vacío.");
                }
            }

            for (bool notaValida = false; !notaValida; )
            {
                Console.Write("Ingrese la nota (escala de 0.0 a 5.0): ");
                
                if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0.0 && nota <= 5.0)
                {
                    calificaciones[i] = nota;
                    notaValida = true;
                }
                else
                {
                    Console.WriteLine("Debe ser un número decimal entre 0.0 y 5.0.");
                }
            }
        }

        double sumaNotas = 0;
        double notaMayor = calificaciones[0];
        double notaMenor = calificaciones[0];
        int aprobados = 0;
        int reprobados = 0;

        for (int i = 0; i < totalEstudiantes; i++)
        {
            double notaActual = calificaciones[i];
            sumaNotas += notaActual;

            if (notaActual > notaMayor)
            {
                notaMayor = notaActual;
            }

            if (notaActual < notaMenor)
            {
                notaMenor = notaActual;
            }

            if (notaActual >= 3.0)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

        double promedioGrupo = sumaNotas / totalEstudiantes;
        Console.WriteLine("REPORTE FINAL DEL GRUPO");
        for (int i = 0; i < totalEstudiantes; i++)
        {
            string estado = calificaciones[i] >= 3.0 ? "Aprobado" : "Reprobado";
            Console.WriteLine($"- {nombres[i]}: {calificaciones[i]:F2} ({estado})");
        }
    }
}
