using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== EJEMPLO: CONTADORES Y ACUMULADORES ===");

        int contadorPares = 0;    // Se inicia en 0
        int sumaTotales = 0;      // Se inicia en 0

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            int num = int.Parse(Console.ReadLine());

            // Lógica de Acumulador (Sumar todo)
            sumaTotales += num; 

            // Lógica de Contador (Solo si es par)
            if (num % 2 == 0)
            {
                contadorPares++;
            }
        }

        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine("La suma de todos los números es: " + sumaTotales);
        Console.WriteLine("Cantidad de números pares hallados: " + contadorPares);
    }
}
