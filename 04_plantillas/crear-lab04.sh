#!/bin/bash

echo "🚀 Iniciando Laboratorio 04: Estructura Switch..."

BASE=~/programacion1/trabajos/lab04_estudiante

mkdir -p $BASE
cd $BASE

dotnet new console --force

cat > Program.cs << 'EOF'
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== BIENVENIDO A FAST-FOOD UMG ===");
        Console.WriteLine("1. Hamburguesa");
        Console.WriteLine("2. Pizza");
        Console.WriteLine("3. Ensalada");
        Console.Write("Seleccione una opción: ");

        // PASO 1: Leer la opción del usuario
        
        // PASO 2: Implementar el switch
        // No olvides el 'break;' en cada caso
        
        // PASO 3: Mostrar el precio correspondiente
        
        // PASO 4: Configurar el 'default' para opciones inválidas
    }
}
EOF

cat > README.md << 'EOF'
# RETO: MENÚ CON SWITCH

Instrucciones:
1. Usa la estructura `switch` para evaluar la opción numérica del usuario.
2. Cada caso debe mostrar el precio del producto.
3. Asegúrate de manejar errores con `default`.

Ejecución:
dotnet run
EOF

echo "✅ Laboratorio 04 listo en: $BASE"
