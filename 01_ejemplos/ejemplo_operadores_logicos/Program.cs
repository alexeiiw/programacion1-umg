using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== EJEMPLO: OPERADORES LÓGICOS ===");

        // Ejemplo de AND (&&)
        Console.WriteLine("--- Validación de Login ---");
        string usuario = "admin";
        string clave = "1234";

        if (usuario == "admin" && clave == "1234")
        {
            Console.WriteLine("Login exitoso (Se cumplieron AMBAS condiciones).");
        }

        // Ejemplo de OR (||)
        Console.WriteLine("\n--- Descuento de Tercera Edad o Niño ---");
        int edad = 70;
        
        if (edad >= 60 || edad <= 10)
        {
            Console.WriteLine("Tienes descuento (Se cumplió UNA de las dos).");
        }

        // Ejemplo de NOT (!)
        bool estaLloviendo = false;
        if (!estaLloviendo)
        {
            Console.WriteLine("\nPuedes salir a caminar, no está lloviendo.");
        }
    }
}
