/*
 * ======================================================================================
 * UNIVERSIDAD MARIANO GÁLVEZ DE GUATEMALA
 * FACULTAD DE INGENIERÍA EN SISTEMAS
 * PROYECTO: Sistema "Inventario-Express" (Arquitectura Matricial)
 * DESCRIPCIÓN: Matriz [10, 2] para gestión de códigos y precios.
 * REQUISITOS: Main centralizado, cálculo de promedio y reporte de superación.
 * ======================================================================================
 */

using System;

namespace InventarioExpressMatricial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definición de matriz: 10 filas (productos), 2 columnas (0=Código, 1=Precio)
            const int TOTAL_PRODUCTOS = 10;
            double[,] inventario = new double[TOTAL_PRODUCTOS, 2];
            double acumuladorPrecios = 0;
            double promedio = 0;

            Console.Title = "Sistema Inventario-Express [Arquitectura 2D]";
            Console.WriteLine("==========================================================");
            Console.WriteLine("        SISTEMA INVENTARIO-EXPRESS (MODO MATRICIAL)       ");
            Console.WriteLine("==========================================================");

            // 1. CICLO FOR: Llenado de matriz (Código y Precio)
            for (int i = 0; i < TOTAL_PRODUCTOS; i++)
            {
                Console.WriteLine($"\n--- Ingreso de Producto #{i + 1} ---");
                
                // Ingreso de Código (Columna 0)
                Console.Write("Ingrese el código del producto: ");
                inventario[i, 0] = double.Parse(Console.ReadLine());

                // Ingreso de Precio (Columna 1) con validación
                Console.Write("Ingrese el precio del producto: Q");
                while (!double.TryParse(Console.ReadLine(), out inventario[i, 1]) || inventario[i, 1] < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("ERROR: Precio inválido. Reintente: Q");
                    Console.ResetColor();
                }

                // Acumulación para promedio
                acumuladorPrecios += inventario[i, 1];
            }

            // 2. CÁLCULO ESTADÍSTICO
            promedio = acumuladorPrecios / TOTAL_PRODUCTOS;

            // 3. REPORTE DE FILTRADO
            Console.Clear();
            Console.WriteLine("==========================================================");
            Console.WriteLine($"PRECIO PROMEDIO DEL INVENTARIO: Q{promedio:N2}");
            Console.WriteLine("==========================================================");
            Console.WriteLine("PRODUCTOS CON PRECIO SUPERIOR AL PROMEDIO:");
            Console.WriteLine("CÓDIGO\t\tPRECIO");
            Console.WriteLine("----------------------------------------------------------");

            bool encontrados = false;
            for (int i = 0; i < TOTAL_PRODUCTOS; i++)
            {
                // Comparación directa accediendo a la columna 1 (Precios)
                if (inventario[i, 1] > promedio)
                {
                    // Acceso a la columna 0 (Código) para el reporte
                    Console.WriteLine($"{inventario[i, 0]}\t\tQ{inventario[i, 1]:N2}");
                    encontrados = true;
                }
            }

            if (!encontrados)
            {
                Console.WriteLine("No existen productos con precio superior al promedio.");
            }

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Proceso finalizado. Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}