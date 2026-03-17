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

        // TODO: Solicitar un número

        // TODO: Determinar si es par o impar

        // Ejemplo:
        // Entrada: 4
        // Salida: El número es par
    }
}
EOF

cat > README.md << 'EOF'
LABORATORIO 01

Objetivo:
Determinar si un número es par o impar.

Instrucciones:
1. Solicitar un número
2. Evaluar si es par o impar
3. Mostrar resultado

Ejemplo:
Entrada: 5
Salida: Impar
EOF

echo "Laboratorio creado en:"
echo $BASE
