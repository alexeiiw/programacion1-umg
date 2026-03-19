using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== EJEMPLO DE CICLOS ===");

        // 1. EJEMPLO FOR (Contar hasta 5)
        Console.WriteLine("\n--- Ciclo FOR ---");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Iteración número: " + i);
        }

        // 2. EJEMPLO WHILE (Validar una entrada)
        Console.WriteLine("\n--- Ciclo WHILE ---");
        int contador = 3;
        while (contador > 0)
        {
            Console.WriteLine("El cohete despega en: " + contador);
            contador--; // IMPORTANTE: Si no restas, el ciclo es infinito
        }

        // 3. EJEMPLO DO-WHILE (Menú simple)
        Console.WriteLine("\n--- Ciclo DO-WHILE ---");
        string respuesta = "";
        do
        {
            Console.Write("Escribe 'salir' para terminar: ");
            respuesta = Console.ReadLine().ToLower();
        } while (respuesta != "salir");

        Console.WriteLine("Programa finalizado con éxito.");
    }
}
