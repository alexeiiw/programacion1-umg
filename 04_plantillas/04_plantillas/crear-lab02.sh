#!/bin/bash

echo "🚀 Iniciando Laboratorio 02: Condicionales Avanzados..."

# Definimos la ruta de destino en el espacio de trabajo del alumno
BASE=~/programacion1/trabajos/lab02_estudiante

# Crear carpeta y entrar
mkdir -p $BASE
cd $BASE

# Crear proyecto de consola de .NET
dotnet new console --force

# Crear el Program.cs con la estructura de comentarios para el alumno
cat > Program.cs << 'EOF'
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== LABORATORIO 02: SISTEMA DE BECAS UMG ===");

        // PASO 1: Solicitar el promedio del alumno (0-100)
        // Pista: Usa int.Parse(Console.ReadLine())
        
        // PASO 2: Clasificar el rendimiento con if / else if
        // Menos de 70: Rendimiento Bajo
        // 70 a 89: Rendimiento Estándar
        // 90 o más: Rendimiento Excelente

        // PASO 3: Si el rendimiento es Excelente, preguntar ingreso familiar
        // Aquí debes usar un IF ANIDADO.
        
        // PASO 4: Determinar si es Beca Completa (Ingreso < 3000) 
        // o Beca Parcial (Ingreso >= 3000)

        // PASO 5: Mostrar el resultado final al usuario
    }
}
EOF

# Crear un mini README local para el alumno
cat > README.md << 'EOF'
# RETO: SISTEMA DE BECAS

Instrucciones:
1. Completa el código en Program.cs siguiendo los comentarios.
2. El programa debe distinguir entre 3 tipos de rendimiento.
3. Solo los de "Rendimiento Excelente" pasan al filtro socioeconómico.

Ejecución:
dotnet run

Dudas:
Consulta ~/programacion1/programacion1-umg/01_ejemplos/ejemplo_if_completo
EOF

echo "✅ Laboratorio 02 listo en: $BASE"
