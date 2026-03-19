using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== EJEMPLO: DÍAS DE LA SEMANA ===");

        Console.Write("Ingrese un número del 1 al 3: ");
        int dia = int.Parse(Console.ReadLine());

        switch (dia)
        {
            case 1:
                Console.WriteLine("Hoy es Lunes.");
                break;
            case 2:
                Console.WriteLine("Hoy es Martes.");
                break;
            case 3:
                Console.WriteLine("Hoy es Miércoles.");
                break;
            default:
                Console.WriteLine("Solo conozco hasta el miércoles por ahora.");
                break;
        }

        // Ejemplo con Texto
        Console.Write("\n¿Eres 'profe' o 'estudiante'?: ");
        string rol = Console.ReadLine().ToLower();

        switch (rol)
        {
            case "profe":
                Console.WriteLine("Acceso a modo edición.");
                break;
            case "estudiante":
                Console.WriteLine("Acceso a modo lectura.");
                break;
            default:
                Console.WriteLine("Rol desconocido.");
                break;
        }
    }
}
