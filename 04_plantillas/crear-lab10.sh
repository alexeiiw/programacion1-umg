#!/bin/bash

# Configuración de variables
LAB_NAME="lab10_algoritmos_arreglos"
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

# 3. Generar la Guía en Markdown (README.md) con el estilo definido
cat <<EOF > "$GUIA_FILE"
# 📗 GUÍA 10 - ALGORITMOS DE ARREGLOS

## 🎯 Objetivo
Dominar la manipulación avanzada de datos: desde organizar arreglos multidimensionales hasta implementar algoritmos para buscar y ordenar información eficientemente.

---

## 🧮 1. Arreglos Multidimensionales y Funciones
Los arreglos pueden pasarse como parámetros a métodos para modularizar el código.
- **Paso a funciones:** Se trabaja con la referencia original del arreglo.
- **Multidimensionales:** Estructuras de más de dos dimensiones (como cubos de datos).
- **Lógica:** \`public static void Procesar(int[] datos) { ... }\`

## 🔍 2. Búsqueda y Ordenamiento
- **Búsqueda Lineal:** Revisar elemento por elemento hasta encontrar el objetivo.
- **Ordenamiento (Burbuja):** Intercambiar elementos adyacentes hasta que el mayor "flote" al final.

---

## 🚦 3. Diferencia Visual
Imagina una **Biblioteca**:
- **Arreglo Multidimensional:** Es un estante con varios niveles y secciones.
- **Ordenamiento:** Poner los libros en orden alfabético para facilitar la localización.
- **Búsqueda:** La búsqueda lineal es revisar cada lomo de libro uno tras otro.



---

## 🧭 El Reto: El Almacén Inteligente
Gestiona un inventario de productos mediante un arreglo:

1. **Carga:** Crear un método \`LlenarArreglo\` que asigne valores aleatorios.
2. **Ordenamiento:** Implementar \`OrdenarBurbuja\` para organizar los precios.
3. **Búsqueda:** Crear un método \`BuscarPrecio\` usando **Búsqueda Lineal**.
4. **Salida:** Mostrar el inventario antes, después de ordenar y el resultado de una búsqueda.

---

## 💡 Referencia de Código
Revisa la implementación de algoritmos de intercambio (swap) y paso de parámetros en:
\`~/programacion1/programacion1-umg/01_ejemplos/ejemplo_algoritmos\`

---

## 🚀 Instrucciones
1. Actualiza: \`git pull\`
2. Genera: \`crear-lab 10\`
3. Carpeta de trabajo: \`~/programacion1/trabajos/$LAB_NAME\`
EOF

echo "✅ Guía generada en $GUIA_FILE"
echo "📂 Abriendo en VS Code..."
code .
