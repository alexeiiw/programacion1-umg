#!/bin/bash

echo "🚀 Configurando Laboratorio 01: Hola Mundo UMG..."

# Ruta de trabajo del alumno
BASE=~/programacion1/trabajos/lab01_estudiante

mkdir -p $BASE
cd $BASE

# Forzamos la creación de un nuevo proyecto de consola
dotnet new console --force

# Inyectamos el código base con instrucciones
cat > Program.cs << 'EOF'
using System;

class Program
{
    static void Main()
    {
        // ----- INSTRUCCIONES -----
        // 1. Usa Console.WriteLine(""); para mostrar mensajes.
        // 2. Escribe un saludo para "Programación 1 - Sede Portales".
        // 3. Escribe tu nombre completo abajo.

        Console.WriteLine("¡Hola Mundo!");
        
        // Escribe aquí tu código:

    }
}
EOF

# Creamos el README específico del lab
cat > README.md << 'EOF'
# LABORATORIO 01 - HOLA MUNDO

Este es tu primer paso en el curso. 

TAREAS:
1. Modifica Program.cs.
2. Agrega una bienvenida a la "Sede Portales".
3. Ejecuta el programa usando el comando: dotnet run

Si el programa muestra los mensajes correctamente, ¡tu entorno está listo!
EOF

echo "✅ Laboratorio 01 creado exitosamente."
echo "👉 Ve a: cd $BASE"
