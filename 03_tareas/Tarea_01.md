# Resolución: Tarea 01 - Sistema de Validación de Crédito Bancario

Este programa evalúa la elegibilidad de un cliente basándose en su edad, ingresos mensuales y estabilidad laboral o patrimonial.

### Criterios de aceptación:
1. **Edad:** 21 a 65 años.
2. **Ingresos:** > Q5,000.00 (sin valores negativos).
3. **Estabilidad:** > 2 años de empleo **O** tener propiedad.

```csharp
using System;

namespace TareaCreditoBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE VALIDACIÓN DE CRÉDITO ===");

            // 1. Entrada de datos
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("Ingrese sus ingresos mensuales (Q): ");
            double ingresos = double.Parse(Console.ReadLine());

            // Validación de ingresos no negativos
            if (ingresos < 0)
            {
                Console.WriteLine("Error: Los ingresos no pueden ser negativos.");
                return; 
            }

            Console.Write("¿Cuántos años lleva en su empleo actual?: ");
            int añosEmpleo = int.Parse(Console.ReadLine());

            Console.Write("¿Posee propiedad propia? (si/no): ");
            bool tienePropiedad = Console.ReadLine().ToLower() == "si";

            // 2. Lógica de validación con operadores lógicos
            // Condición 1: Edad entre 21 y 65
            bool edadValida = (edad >= 21) && (edad <= 65);

            // Condición 2: Ingresos mayores a 5000
            bool ingresosValidos = ingresos > 5000;

            // Condición 3: Estabilidad (Más de 2 años O propiedad)
            bool estabilidadValida = (añosEmpleo > 2) || tienePropiedad;

            // Resultado Final: Se deben cumplir las tres condiciones principales
            if (edadValida && ingresosValidos && estabilidadValida)
            {
                Console.WriteLine("\nRESULTADO: Crédito APROBADO.");
            }
            else
            {
                Console.WriteLine("\nRESULTADO: Crédito RECHAZADO.");
                Console.WriteLine("Motivo: No cumple con uno o más de los criterios mínimos.");
            }

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
