internal class Program
{
    private static void Main(string[] args)
    {

        {
            // Inicialización del código, inicialmente se declaran 4 variables con el fin de validar cantidad de estudiantes
            bool Evaluar = true;

            while (Evaluar)
            {
                int NumEstudiantes = 0;
                int EstGanaron = 0;
                int EstPerdieron = 0;

                Console.WriteLine("Ingrese la cantidad de estudiantes a evaluar:");
                NumEstudiantes = int.Parse(Console.ReadLine());

                // Creación del for en donde se llevará a cabo la estructura de la cantidad de jugadores y notas

                for (int i = 1; i <= NumEstudiantes; i++)
                {
                    Console.WriteLine($"Ingrese la cantidad de notas para el estudiante {i}:");
                    int NumNotas = int.Parse(Console.ReadLine());

                    double Notas = 0;

                    for (int x = 1; x <= NumNotas; x++)
                    {
                        Console.WriteLine($"Ingrese la nota {x} del estudiante {i}:");
                        double nota = double.Parse(Console.ReadLine());
                        Notas += nota;
                    }

                    // Se calcula el promedio de las notas

                    double Promedio = Notas / NumNotas;
                    Console.WriteLine($"El promedio del estudiante {i} es: {Promedio}");

                    // Clasificación del estudiante según el promedio
                    if (Promedio >= 4.5)
                    {
                        Console.WriteLine("Categoría: Excelente");
                    }
                    else if (Promedio >= 4.0 && Promedio < 4.5)
                    {
                        Console.WriteLine("Categoría: Sobresaliente");
                    }
                    else if (Promedio >= 3.5 && Promedio < 4.0)
                    {
                        Console.WriteLine("Categoría: Bueno");
                    }
                    else
                    {
                        Console.WriteLine("Categoría: Insuficiente");
                    }









                }
            }
        }
    }
}
