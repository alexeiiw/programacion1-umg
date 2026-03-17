#!/bin/bash

echo "Creando laboratorio 01..."

BASE=~/programacion1/trabajos/lab01_estudiante

mkdir -p $BASE
cd $BASE

dotnet new console

cat > Program.cs << 'EOF'
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("LABORATORIO 01 - IF");

        // Paso 1:
        // Solicitar un número al usuario

        // Paso 2:
        // Determinar si el número es par o impar

        // Paso 3:
        // Mostrar el resultado en consola

    }
}
EOF

cat > README.md << 'EOF'
LABORATORIO 01 - IF

OBJETIVO:
Determinar si un número es par o impar.

PASOS:
1. Solicitar un número
2. Evaluar si es par o impar
3. Mostrar resultado

PISTA:
Puedes usar el operador %

SI TIENES DUDAS:
Revisa el ejemplo en:
01_ejemplos/ejemplo_if
EOF

echo "Laboratorio creado en:"
echo $BASE