using System;

internal class Program
{
    private static void Main(string[] args)
    {
        bool JugarNuevo = true;

        while (JugarNuevo)
        {
            // Mensaje de bienvenida y solicitud de número de jugadores
            int NumJugadores = 0;
            while (NumJugadores < 2 || NumJugadores > 4)
            {
                Console.WriteLine("Bienvenidos al juego, Adivina el número! ");
                Console.WriteLine("Ingrese el número de jugadores (mínimo 2, máximo 4): ");
                NumJugadores = int.Parse(Console.ReadLine());
            }
              
            //Se usa la función random, la cual permite valores aleatorios
            Random R = new Random();
            int NumAle = 0;

            // Se genera un número aleatorio y se usa la función se switch con la variable NumJugadores

            switch (NumJugadores)
            {
                case 2:
                    NumAle = R.Next(0, 51); // 0 a 50
                    break;

                case 3:
                    NumAle = R.Next(0, 101); // 0 a 101
                    break;

                case 4:
                    NumAle = R.Next(0, 201); // 0 a 201
                    break;
                default:
                    Console.WriteLine($"Numero de jugadores inválidos");
                    break;
            }

            bool Adivina = false;
            int Turno = 0;

            // 3. Turnos de los jugadores
            while (!Adivina)
            {
                int JugadorActual = (Turno % NumJugadores) + 1;
                Console.WriteLine($"Turno del jugador {JugadorActual}: Ingrese su número: ");
                int Participar = int.Parse(Console.ReadLine());

                if (Participar > NumAle)
                {
                    Console.WriteLine("MENOR");
                }
                else if (Participar < NumAle)
                {
                    Console.WriteLine("MAYOR");
                }
                else
                {
                    Console.WriteLine($"¡HAS GANADO, jugador {JugadorActual}!");
                    Adivina = true;
                }
                Turno++;
            }






        }
    }
}