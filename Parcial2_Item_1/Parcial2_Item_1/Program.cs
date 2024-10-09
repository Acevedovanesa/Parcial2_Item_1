using System;

internal class Program
{
    private static void Main(string[] args)
    {
        bool JugarNuevo = true;

        while (JugarNuevo)
        {
            // 1. Pedir cantidad de jugadores
            int NumJugadores = 0;
            while (NumJugadores < 2 || NumJugadores > 4)
            {
                Console.WriteLine("Bienvenidos al juego, Adivina el número! ");
                Console.WriteLine("Ingrese el número de jugadores (mínimo 2, máximo 4): ");
                NumJugadores = int.Parse(Console.ReadLine());
            }



        }
    }
}