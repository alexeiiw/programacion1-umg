#!/bin/bash

echo "🚀 Iniciando Laboratorio 05: Ciclos e Iteraciones..."

BASE=~/programacion1/trabajos/lab05_estudiante

mkdir -p $BASE
cd $BASE

dotnet new console --force

cat > Program.cs << 'EOF'
using System;

class Program
{
    static void Main()
    {
        // TAREA 1: TABLA DE MULTIPLICAR (FOR)
        Console.Write("Ingrese un número para ver su tabla: ");
        int tabla = int.Parse(Console.ReadLine());
        // TODO: Usa un for de 1 a 10 para mostrar los resultados

        // TAREA 2: CUENTA REGRESIVA (WHILE)
        Console.WriteLine("\nIniciando cuenta regresiva...");
        // TODO: Usa un while que empiece en 10 y baje hasta 1
        
        // TAREA 3: VALIDACIÓN DE SALIDA (DO-WHILE)
        int numero;
        // TODO: Usa un do-while que pida un número 
        // y se detenga cuando el número sea 0
    }
}
EOF

cat > README.md << 'EOF'
# RETO: DOMINANDO LOS CICLOS

Instrucciones:
1. Completa las 3 tareas en Program.cs.
2. Asegúrate de que tus ciclos tengan una "condición de salida" (que no sean infinitos).
3. Prueba ingresando números diferentes.

Ejecución:
dotnet run
EOF

echo "✅ Laboratorio 05 listo en: $BASE"
