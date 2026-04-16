# 📗 GUÍA 09 - MATRICES (ARREGLOS BIDIMENSIONALES)

## 🎯 Objetivo
Aprender a organizar datos en estructuras de filas y columnas, permitiendo manejar información más compleja como tablas, mapas o cuadrículas de juegos.

---

## 🧮 1. ¿Qué es una Matriz?
Una **matriz** es un arreglo de dos dimensiones. Si un arreglo normal es una fila de casillas, una matriz es una hoja de cuadrícula completa.
- **Uso:** Tableros de juegos, hojas de cálculo, procesamiento de imágenes.
- **Lógica:** Para acceder a un dato necesitas dos coordenadas: `matriz[fila, columna]`.

## 💰 2. Declaración e Inicialización
En C#, las matrices se definen usando una coma dentro de los corchetes `[,]`.
- **Declaración:** `int[,] tablero = new int[3, 3];` (Crea una malla de 3x3).
- **Asignación:** `tablero[0, 1] = 5;` (Guarda el 5 en la primera fila, segunda columna).

---

## 🚦 3. Diferencia Visual
Imagina un **Edificio de Apartamentos**:
- El **Arreglo (Vector)** es un edificio de un solo piso: solo necesitas el número de puerta.
- La **Matriz** es un edificio de varios niveles: necesitas el número de piso (fila) y el número de puerta (columna).


---

## 🧭 El Reto: Mapa de Tesoro Simple

Vas a crear un programa que gestione una matriz pequeña de 3x3:

1. **Entrada:** Crear una matriz de enteros de 3x3.
2. **Proceso:** - Llenar la matriz con números aleatorios del 1 al 10 usando un ciclo `for` anidado.
   - Pedir al usuario una fila y una columna para "buscar un tesoro".
3. **Salida:** - Imprimir la matriz completa en formato de tabla.
   - Mostrar qué valor hay en la posición que el usuario eligió.

---

## 💡 Referencia de Código
Revisa cómo recorrer matrices usando ciclos `for` anidados en:
`~/programacion1/programacion1-umg/01_ejemplos/ejemplo_matrices`

---

## 🚀 Instrucciones
1. Actualiza: `git pull`
2. Genera: `crear-lab 09`
3. Carpeta de trabajo: `~/programacion1/trabajos/lab09_estudiante`
