using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== EJEMPLO: REGISTRO DE PRODUCTO ===");

        // Captura de múltiples tipos
        Console.Write("Nombre del producto: ");
        string nombre = Console.ReadLine();

        Console.Write("Precio (decimal): ");
        double precio = double.Parse(Console.ReadLine());

        Console.Write("Cantidad en inventario: ");
        int stock = int.Parse(Console.ReadLine());

        // VALIDACIÓN BÁSICA
        if (string.IsNullOrEmpty(nombre))
        {
            Console.WriteLine("ERROR: El nombre no puede estar vacío.");
        }
        else if (precio <= 0 || stock < 0)
        {
            Console.WriteLine("ERROR: Los valores numéricos no son lógicos.");
        }
        else
        {
            Console.WriteLine("\n--- PRODUCTO REGISTRADO ---");
            Console.WriteLine($"Item: {nombre} | Total en bodega: Q{precio * stock}");
        }
    }
}
