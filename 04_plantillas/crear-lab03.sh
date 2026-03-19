#!/bin/bash

echo "🚀 Iniciando Laboratorio 03: Operadores Lógicos..."

BASE=~/programacion1/trabajos/lab03_estudiante

mkdir -p $BASE
cd $BASE

dotnet new console --force

cat > Program.cs << 'EOF'
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== LABORATORIO 03: REQUISITOS DE BECA 2.0 ===");

        // PASO 1: Solicitar el promedio del alumno
        
        // PASO 2: Solicitar la cantidad de faltas del alumno
        
        // PASO 3: Evaluar usando el operador lógico AND (&&)
        // Condición: Promedio mayor o igual a 90 Y faltas menor o igual a 2
        
        // PASO 4: Mostrar si aplica o no a la beca
        
        // RETO EXTRA (Opcional): 
        // Usa el operador OR (||) para decir que el alumno tiene "Alerta" 
        // si el promedio es menor a 61 O las faltas son mayores a 10.
    }
}
EOF

cat > README.md << 'EOF'
# RETO: OPERADORES LÓGICOS

Instrucciones:
1. Usa el operador `&&` para validar que se cumplan dos condiciones al mismo tiempo.
2. No uses if anidados, intenta hacerlo en una sola línea de condición.

Ejecución:
dotnet run
EOF

echo "✅ Laboratorio 03 listo en: $BASE"
