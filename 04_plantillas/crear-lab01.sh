#!/bin/bash

echo "🚀 Generando Laboratorio 01 - Bienvenida Sede Portales..."

BASE=~/programacion1/trabajos/lab01_estudiante

mkdir -p $BASE
cd $BASE

dotnet new console --force

cat > Program.cs << 'EOF'
using System;

class Program
{
    static void Main()
    {
        // TAREA:
        // 1. Muestra un mensaje de "Hola Mundo"
        // 2. Muestra un mensaje de bienvenida al curso "Programación 1 - Sede Portales"
        // 3. Muestra tu nombre y número de carné (puedes inventarlo)

        Console.WriteLine("Escribe tu código aquí abajo:");

    }
}
EOF

cat > README.md << 'EOF'
# LABORATORIO 01: EL INICIO

Este es tu primer contacto con el código. 

## Instrucciones:
1. Abre Program.cs
2. Usa `Console.WriteLine` para imprimir los mensajes solicitados.
3. Ejecuta con `dotnet run`.

## Objetivo:
Asegurarte de que puedes escribir, compilar y ejecutar código sin errores.
EOF

echo "✅ Lab 01 listo. El alumno debe ir a: $BASE"
