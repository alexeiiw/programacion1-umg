#!/bin/bash

# Configuración de variables
LAB_NAME="lab08_recursividad"
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
# 📗 GUÍA 08 - RECURSIVIDAD

## 🎯 Objetivo
Comprender cómo una función puede resolverse a sí misma dividiendo un problema grande en piezas pequeñas hasta llegar a un punto de parada.

---

## 🔄 1. ¿Qué es la Recursividad?
La **recursividad** ocurre cuando una función se llama a sí misma dentro de su propio cuerpo. Es una alternativa a los ciclos para resolver problemas con estructuras repetitivas.
- **Uso:** Factoriales, potencias, recorridos de árboles.
- **Lógica:** Bajar niveles de complejidad hasta encontrar una respuesta conocida.

## 🛑 2. Los dos Pilares Obligatorios
1. **Caso Base:** La condición que detiene las llamadas (el "freno").
2. **Caso Recursivo:** Donde la función se llama a sí misma acercándose al caso base.

---

## 🚦 3. Diferencia Visual
Imagina una **Muñeca Rusa (Matrioshka)**:
- El **Caso Recursivo** es abrir una muñeca para encontrar otra más pequeña.
- El **Caso Base** es la muñeca más pequeña que ya no se puede abrir.

---

## 🧭 El Reto: Sumatoria Progresiva
Implementa un programa que calcule la suma de todos los números desde **N** hasta 1 usando recursividad.

1. **Entrada:** Pedir al usuario un número entero positivo.
2. **Función:** Crear un método \`SumarRecursivo(int n)\`.
3. **Proceso:** - Si \`n == 1\`, retornar 1 (**Caso Base**).
   - Si no, retornar \`n + SumarRecursivo(n - 1)\` (**Caso Recursivo**).
4. **Salida:** Mostrar el resultado final en consola.

---

## 💡 Referencia de Código
Revisa la estructura de los métodos y el flujo de la pila de llamadas en:
\`~/programacion1/programacion1-umg/01_ejemplos/ejemplo_recursividad\`

---

## 🚀 Instrucciones
1. Actualiza: \`git pull\`
2. Genera: \`crear-lab 08\`
3. Carpeta de trabajo: \`~/programacion1/trabajos/lab08_estudiante\`
EOF

echo "✅ Guía generada en $GUIA_FILE"
echo "📂 Abriendo en VS Code..."
code .
