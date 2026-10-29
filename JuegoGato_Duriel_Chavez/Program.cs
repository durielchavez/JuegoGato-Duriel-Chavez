using System;

namespace JuegoGato
{
    internal class Program
    {
        private static char[] tablero = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private static char jugadorActual = 'X';

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool jugarDeNuevo = true;

            Console.WriteLine("=================================");
            Console.WriteLine("       JUEGO DE GATO (X/O)");
            Console.WriteLine("       Estudiante: Duriel Chavez");
            Console.WriteLine("=================================");

            while (jugarDeNuevo)
            {
                ReiniciarTablero();
                jugadorActual = 'X';
                bool hayGanador = false;
                bool hayEmpate = false;

                while (!hayGanador && !hayEmpate)
                {
                    Console.Clear();
                    MostrarTitulo();
                    DibujarTablero();

                    int posicion = SolicitarPosicion();
                    tablero[posicion] = jugadorActual;

                    hayGanador = VerificarGanador();
                    if (!hayGanador)
                    {
                        hayEmpate = VerificarEmpate();
                    }

                    if (!hayGanador && !hayEmpate)
                    {
                        jugadorActual = jugadorActual == 'X' ? 'O' : 'X';
                    }
                }

                Console.Clear();
                MostrarTitulo();
                DibujarTablero();

                if (hayGanador)
                {
                    Console.WriteLine($"\n¡Felicidades! El jugador {jugadorActual} ha ganado.");
                }
                else
                {
                    Console.WriteLine("\nEl juego terminó en empate.");
                }

                Console.Write("\n¿Desean jugar otra vez? (S/N): ");
                string respuesta = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();
                jugarDeNuevo = respuesta == "S";
            }

            Console.WriteLine("\nGracias por jugar. ¡Hasta la próxima!");
        }

        private static void MostrarTitulo()
        {
            Console.WriteLine("=================================");
            Console.WriteLine("          JUEGO DE GATO");
            Console.WriteLine("=================================\n");
        }

        private static void DibujarTablero()
        {
            Console.WriteLine($" {tablero[0]} | {tablero[1]} | {tablero[2]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {tablero[3]} | {tablero[4]} | {tablero[5]} ");
            Console.WriteLine("---+---+---");
            Console.WriteLine($" {tablero[6]} | {tablero[7]} | {tablero[8]} ");
            Console.WriteLine();
        }

        private static int SolicitarPosicion()
        {
            while (true)
            {
                Console.Write($"Turno del jugador {jugadorActual}. Elige una casilla (1-9): ");
                string entrada = (Console.ReadLine() ?? "").Trim();

                if (int.TryParse(entrada, out int numero) && numero >= 1 && numero <= 9)
                {
                    int indice = numero - 1;
                    if (tablero[indice] != 'X' && tablero[indice] != 'O')
                    {
                        return indice;
                    }

                    Console.WriteLine("Esa casilla ya está ocupada. Elige otra.");
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Escribe un número del 1 al 9.");
                }
            }
        }

        private static bool VerificarGanador()
        {
            int[,] combinaciones =
            {
                { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
                { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
                { 0, 4, 8 }, { 2, 4, 6 }
            };

            for (int i = 0; i < combinaciones.GetLength(0); i++)
            {
                int a = combinaciones[i, 0];
                int b = combinaciones[i, 1];
                int c = combinaciones[i, 2];

                if (tablero[a] == jugadorActual &&
                    tablero[b] == jugadorActual &&
                    tablero[c] == jugadorActual)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool VerificarEmpate()
        {
            foreach (char casilla in tablero)
            {
                if (casilla != 'X' && casilla != 'O')
                {
                    return false;
                }
            }

            return true;
        }

        private static void ReiniciarTablero()
        {
            for (int i = 0; i < tablero.Length; i++)
            {
                tablero[i] = (char)('1' + i);
            }
        }
    }
}
