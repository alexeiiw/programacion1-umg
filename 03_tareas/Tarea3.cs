using System;

namespace Tarea3_CyberMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            // Acumuladores y variables de estado
            double granTotalDia = 0;
            int totalProductosVendidos = 0;
            int opcionMenu = 0;

            Console.WriteLine("=== BIENVENIDO AL SISTEMA CYBER-MARKET ===");

            // 1. Uso de DO-WHILE para el menú principal
            do
            {
                Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
                Console.WriteLine("1. Registrar Nueva Venta");
                Console.WriteLine("2. Ver Reporte del Día y Salir");
                Console.Write("Seleccione una opción: ");
                opcionMenu = int.Parse(Console.ReadLine());

                if (opcionMenu == 1)
                {
                    double subtotalVenta = 0;
                    
                    Console.Write("\n¿Cuántos productos registrará en esta venta?: ");
                    int cantidadCarga = int.Parse(Console.ReadLine());

                    // 2. Uso de FOR para procesar listado de productos
                    for (int i = 1; i <= cantidadCarga; i++)
                    {
                        Console.WriteLine($"\nProducto #{i}:");
                        Console.WriteLine("Categoría: 1. Electrónica | 2. Ropa | 3. Otros");
                        int categoria = int.Parse(Console.ReadLine());

                        double precio = -1;
                        // 3. Uso de WHILE para validación de datos
                        while (precio < 0)
                        {
                            Console.Write("Ingrese el precio del producto: Q");
                            precio = double.Parse(Console.ReadLine());
                            if (precio < 0) Console.WriteLine("¡Error! El precio debe ser positivo.");
                        }

                        // 4. Uso de SWITCH para lógica por categoría
                        switch (categoria)
                        {
                            case 1:
                                Console.WriteLine("-> Categoría seleccionada: Electrónica");
                                break;
                            case 2:
                                Console.WriteLine("-> Categoría seleccionada: Ropa");
                                break;
                            default:
                                Console.WriteLine("-> Categoría seleccionada: Otros");
                                break;
                        }

                        subtotalVenta += precio; // Acumulador de venta actual
                        totalProductosVendidos++; // Contador
                    }

                    // 5. Uso de IF / IF ANIDADO para descuentos
                    Console.Write("\n¿Tipo de cliente? (1. Premium / 2. Regular): ");
                    int tipoCliente = int.Parse(Console.ReadLine());
                    double descuento = 0;

                    if (tipoCliente == 1) // Premium
                    {
                        if (subtotalVenta > 1000) { descuento = 0.15; }
                        else { descuento = 0.10; }
                    }
                    else if (tipoCliente == 2) // Regular
                    {
                        if (subtotalVenta > 500) { descuento = 0.05; }
                    }

                    double totalConDescuento = subtotalVenta - (subtotalVenta * descuento);
                    Console.WriteLine($"\nSubtotal: Q{subtotalVenta:N2}");
                    Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
                    Console.WriteLine($"Total a Pagar: Q{totalConDescuento:N2}");

                    granTotalDia += totalConDescuento; // Acumulador del gran total
                }

            } while (opcionMenu != 2); // Cierre del menú principal

            // Reporte final
            Console.WriteLine("\n========================================");
            Console.WriteLine("REPORTE FINAL DE JORNADA");
            Console.WriteLine($"Total de productos vendidos: {totalProductosVendidos}");
            Console.WriteLine($"Ingreso Total del Día: Q{granTotalDia:N2}");
            Console.WriteLine("========================================");
            Console.ReadKey();
        }
    }
}