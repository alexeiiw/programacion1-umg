using System;

class Program
{
    static void Main()
    {
        // El saludo inicial del curso
        Console.WriteLine("==============================================");
        Console.WriteLine("   BIENVENIDO A PROGRAMACIÓN 1 - UMG         ");
        Console.WriteLine("            SEDE PORTALES                    ");
        Console.WriteLine("==============================================");
        
        Console.WriteLine("\nHola Mundo. Este es un ejemplo de salida de datos.");
        Console.WriteLine("C# es un lenguaje tipado y potente.");
        
        // Ejemplo de cómo leer un nombre para interactuar
        Console.Write("\n¿Cuál es tu nombre? ");
        string nombre = Console.ReadLine();
        
        Console.WriteLine($"\n¡Gusto en conocerte, {nombre}!");
        Console.WriteLine("Prepárate para aprender a dominar la lógica.");
    }
}
