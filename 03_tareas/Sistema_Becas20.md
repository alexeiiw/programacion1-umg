# Reto: Sistema de Becas 2.0 (Optimizado)

Programa para la asignación de becas basado en el rendimiento académico y asistencia.

## Requisitos Lógicos

- El promedio debe ser >= 90
- El número de faltas debe ser <= 2
- Se utiliza el operador `&&` para asegurar el cumplimiento de ambos

## Código Fuente (Program.cs)

```csharp
using System;

namespace SistemaBecas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE BECAS 2.0 ===");

            Console.Write("Ingrese el promedio: ");
            double promedio = double.Parse(Console.ReadLine());

            Console.Write("Ingrese las faltas: ");
            int faltas = int.Parse(Console.ReadLine());

            // Evaluación lógica
            if (promedio >= 90 && faltas <= 2)
            {
                Console.WriteLine("\nFelicidades, aplicas a la beca.");
            }
            else
            {
                Console.WriteLine("\nLo sentimos, no cumples con todos los requisitos.");
            }
        }
    }
}
