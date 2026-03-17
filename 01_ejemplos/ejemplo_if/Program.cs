using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("EJEMPLO - IF");

        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par");
        }
        else
        {
            Console.WriteLine("El número es impar");
        }
    }
}