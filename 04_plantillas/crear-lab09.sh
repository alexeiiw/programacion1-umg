#!/bin/bash

# Configuración de variables
LAB_NAME="lab09_matrices"
LAB_DIR="$HOME/programacion1/trabajos/$LAB_NAME"
GUIA_FILE="$LAB_DIR/README.md"

echo "🚀 Iniciando creación del entorno de laboratorio: $LAB_NAME"

# 1. Crear carpeta del laboratorio
if [ -d "$LAB_DIR" ]; then
    echo "⚠️ La carpeta ya existe. Abriendo..."
else
    mkdir -p "$LAB_DIR"
    echo "✅ Carpeta creada en: $LAB_DIR"
fi

cd "$LAB_DIR"

# 2. Inicializar proyecto de consola C# (si no existe)
if [ ! -f "Program.cs" ]; then
    dotnet new console
    echo "✅ Proyecto C# inicializado."
else
    echo "ℹ️ El proyecto C# ya estaba inicializado."
fi

# 3. Generar la Guía en Markdown (README.md) con el estilo de la GUÍA 09
cat <<EOF > "$GUIA_FILE"
# 📗 GUÍA 09 - MATRICES (ARREGLOS BIDIMENSIONALES)

## 🎯 Objetivo
Aprender a organizar datos en estructuras de filas y columnas, permitiendo manejar información más compleja como tablas o cuadrículas.

---

## 🧮 1. ¿Qué es una Matriz?
Una **matriz** es un arreglo de dos dimensiones (filas y columnas).
- **Uso:** Tableros, hojas de cálculo, mapas de coordenadas.
- **Lógica:** Se accede mediante \`matriz[fila, columna]\`.

## 💰 2. Declaración e Inicialización
- **Declaración:** \`int[,] tablero = new int[3, 3];\`
- **Asignación:** \`tablero[0, 1] = 5;\` (Fila 0, Columna 1).

---

## 🚦 3. Diferencia Visual
Imagina un **Edificio de Apartamentos**:
- El **Vector** es un edificio de un solo piso (solo necesitas el número de puerta).
- La **Matriz** tiene varios niveles (necesitas el piso y la puerta).

---

## 🧭 El Reto: Mapa de Tesoro Simple
Crea un programa que gestione una matriz de 3x3:

1. **Entrada:** Declarar una matriz de enteros de 3x3.
2. **Proceso:** - Llenar la matriz con números aleatorios del 1 al 10 usando ciclos \`for\` anidados.
   - Pedir al usuario coordenadas (fila y columna) para buscar.
3. **Salida:** - Imprimir la matriz en formato de tabla.
   - Mostrar el valor encontrado en la posición elegida.

---

## 💡 Referencia de Código
Revisa cómo recorrer matrices usando ciclos \`for\` anidados en:
\`~/programacion1/programacion1-umg/01_ejemplos/ejemplo_matrices\`

---

## 🚀 Instrucciones
1. Actualiza: \`git pull\`
2. Genera: \`crear-lab 09\`
3. Carpeta de trabajo: \`~/programacion1/trabajos/lab09_estudiante\`
EOF

echo "✅ Guía generada en $GUIA_FILE"
echo "📂 Abriendo en VS Code..."
code .
