#!/bin/bash

echo "🚀 Iniciando Laboratorio 06: Contadores y Acumuladores..."

BASE=~/programacion1/trabajos/lab06_estudiante

mkdir -p $BASE
cd $BASE

dotnet new console --force

cat > Program.cs << 'EOF'
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE VENTAS UMG ===");

        // PASO 1: Inicializar variables (Contadores y Acumuladores) en 0
        double totalVenta = 0;
        int productosCaros = 0;

        // PASO 2: Preguntar cuántos productos se procesarán
        Console.Write("¿Cuántos productos desea ingresar? ");
        int cantidad = int.Parse(Console.ReadLine());

        // PASO 3: Crear el ciclo for
        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Precio del producto {i}: ");
            double precio = double.Parse(Console.ReadLine());

            // PASO 4: Acumular el precio al totalVenta
            
            // PASO 5: Contar si el producto es mayor a 100
        }

        // PASO 6: Mostrar resultados finales
        Console.WriteLine("\n--- RESUMEN ---");
        Console.WriteLine($"Total a pagar: Q{totalVenta}");
        Console.WriteLine($"Productos con precio mayor a 100: {productosCaros}");
    }
}
EOF

cat > README.md << 'EOF'
# RETO: CAJA REGISTRADORA

Instrucciones:
1. Completa la lógica de acumulación y conteo dentro del ciclo.
2. Asegúrate de mostrar el total al final (fuera del ciclo).

Ejecución:
dotnet run
EOF

echo "✅ Laboratorio 06 listo en: $BASE"
