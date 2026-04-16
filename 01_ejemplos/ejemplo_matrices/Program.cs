using System;

namespace LaboratorioMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            // Título del programa
            Console.WriteLine("========================================");
            Console.WriteLine("     SISTEMA DE MATRICES (TESORO)       ");
            Console.WriteLine("========================================\n");

            // 1. Declaración de una matriz de 3x3 (Filas, Columnas)
            int[,] mapa = new int[3, 3];
            Random azar = new Random();

            // 2. Proceso: Llenado de la matriz con números aleatorios
            // Usamos un ciclo anidado (un for dentro de otro)
            for (int fila = 0; fila < 3; fila++)
            {
                for (int col = 0; col < 3; col++)
                {
                    mapa[fila, col] = azar.Next(1, 11); // Números del 1 al 10
                }
            }

            // 3. Salida: Mostrar la matriz en formato de tabla
            Console.WriteLine("Mapa generado:");
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write($"[{mapa[f, c]}] ");
                }
                Console.WriteLine(); // Salto de línea al terminar cada fila
            }

            // 4. Interacción: Buscar el "tesoro"
            Console.WriteLine("\n--- BUSCADOR DE TESOROS ---");
            Console.Write("Ingrese fila (0-2): ");
            int fUsuario = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese columna (0-2): ");
            int cUsuario = int.Parse(Console.ReadLine());

            // Validación simple y salida
            if (fUsuario >= 0 && fUsuario < 3 && cUsuario >= 0 && cUsuario < 3)
            {
                int valorEncontrado = mapa[fUsuario, cUsuario];
                Console.WriteLine($"\n¡Encontraste el valor: {valorEncontrado}!");
            }
            else
            {
                Console.WriteLine("\nCoordenadas fuera de rango.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
