using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== EJEMPLO: SISTEMA DE ACCESO Y CATEGORÍAS ===");

        // 1. Uso de comparaciones y else if (La Escalera)
        Console.Write("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad < 0) 
        {
            Console.WriteLine("Error: La edad no puede ser negativa.");
        }
        else if (edad < 13) 
        {
            Console.WriteLine("Categoría: Niño.");
        }
        else if (edad < 18) 
        {
            Console.WriteLine("Categoría: Adolescente.");
        }
        else 
        {
            // 2. Uso de IF ANIDADO (Pregunta dentro de otra)
            // Solo llegamos aquí si la persona es mayor o igual a 18
            Console.WriteLine("Categoría: Adulto.");

            Console.Write("¿Tiene invitación VIP? (si/no): ");
            string tieneInvitacion = Console.ReadLine().ToLower();

            // Comparación de texto
            if (tieneInvitacion == "si") 
            {
                Console.WriteLine(">> ACCESO CONCEDIDO AL ÁREA VIP <<");
            }
            else 
            {
                Console.WriteLine(">> ACCESO AL ÁREA GENERAL <<");
            }
        }

        Console.WriteLine("\nGracias por usar el sistema.");
    }
}
