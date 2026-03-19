#!/bin/bash

echo "🚀 Iniciando Laboratorio 07: Entradas y Validaciones..."

BASE=~/programacion1/trabajos/lab07_estudiante

mkdir -p $BASE
cd $BASE

dotnet new console --force

cat > Program.cs << 'EOF'
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE INSCRIPCIÓN DE ATLETAS ===");

        // PASO 1: Solicitar Nombre Completo (string)
        
        // PASO 2: Solicitar Edad (int)
        
        // PASO 3: Solicitar Tiempo Récord (double)

        // PASO 4: Validaciones
        // - El nombre no debe estar vacío
        // - La edad debe ser entre 15 y 90 años
        // - El tiempo debe ser mayor a 0

        // PASO 5: Si todo es correcto, mostrar resumen
        // Si no, mostrar el mensaje de error correspondiente
    }
}
EOF

cat > README.md << 'EOF'
# RETO: FORMULARIO DE ATLETAS

Instrucciones:
1. Captura 3 tipos de datos distintos.
2. Implementa validaciones con `if` y `else if` para evitar datos erróneos.
3. Muestra un mensaje amigable al final si el registro fue exitoso.

Ejecución:
dotnet run
EOF

echo "✅ Laboratorio 07 listo en: $BASE"
