using System;

namespace LaboratorioRecursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            // Título del programa
            Console.WriteLine("========================================");
            Console.WriteLine("   DEMOSTRACIÓN DE RECURSIVIDAD (UMG)   ");
            Console.WriteLine("========================================\n");

            // 1. Solicitar datos al usuario
            Console.Write("Ingrese un número entero para sumar sus antecesores: ");
            if (int.TryParse(Console.ReadLine(), out int numeroUsuario) && numeroUsuario > 0)
            {
                // 2. Llamada a la función recursiva
                int resultado = SumarRecursivo(numeroUsuario);

                // 3. Mostrar el resultado final
                Console.WriteLine($"\nLa suma total desde {numeroUsuario} hasta 1 es: {resultado}");
            }
            else
            {
                Console.WriteLine("Error: Por favor ingrese un número entero positivo.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        /// <summary>
        /// Método que suma números de forma recursiva
        /// </summary>
        /// <param name="n">Número actual a sumar</param>
        /// <returns>La suma acumulada</returns>
        static int SumarRecursivo(int n)
        {
            // --- CASO BASE ---
            // Si llegamos a 1, detenemos las llamadas y devolvemos 1.
            if (n == 1)
            {
                Console.WriteLine("Llegamos al Caso Base: 1");
                return 1;
            }

            // --- CASO RECURSIVO ---
            // Sumamos el valor actual (n) con el resultado de la función 
            // llamándose a sí misma con un valor menor (n - 1).
            Console.WriteLine($"Procesando: {n} + SumarRecursivo({n - 1})");
            return n + SumarRecursivo(n - 1);
        }
    }
}
