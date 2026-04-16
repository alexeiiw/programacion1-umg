# 📗 GUÍA 10 - GESTIÓN Y ALGORITMOS DE ARREGLOS

## 🎯 Objetivo
Dominar la manipulación avanzada de datos: desde organizar arreglos multidimensionales hasta implementar algoritmos para buscar y ordenar información eficientemente.

---

## 🧮 1. Arreglos Multidimensionales y Funciones
Los arreglos no solo viven en el `Main`. Podemos pasarlos a funciones para modularizar el código.
- **Paso a funciones:** Al enviar un arreglo a un método, trabajas con la referencia original.
- **Multidimensionales:** Estructuras de más de dos dimensiones (como un cubo de datos `int[,,]`).
- **Lógica:** `public static void Ordenar(int[] datos) { ... }`

## 🔍 2. Búsqueda y Ordenamiento
Organizar la información es clave para encontrarla rápido.
- **Búsqueda Lineal:** Revisar uno por uno hasta encontrar el valor.
- **Búsqueda Binaria:** Más rápida, pero requiere que el arreglo esté **ordenado**. Divide el rango a la mitad en cada paso.
- **Ordenamiento (Burbuja/Selection):** Intercambiar elementos de posición hasta que el menor quede al principio.

---

## 🚦 3. Diferencia Visual
Imagina una **Biblioteca**:
- **Arreglo Multidimensional:** Es un estante con varios niveles y secciones (Fila, Columna, Profundidad).
- **Ordenamiento:** Es poner los libros en orden alfabético para no perder tiempo buscando.
- **Búsqueda Binaria:** Es abrir el diccionario a la mitad; si tu palabra está después, descartas toda la primera mitad de un solo golpe.



---

## 🧭 El Reto: El Almacén Inteligente

Vas a crear un sistema que gestione un inventario de productos (un arreglo de enteros):

1. **Carga:** Crear un método llamado `LlenarArreglo` que reciba un arreglo y lo llene con números aleatorios.
2. **Ordenamiento:** Implementar el método `OrdenarBurbuja` para organizar los precios de menor a mayor.
3. **Búsqueda:** Crear un método `BuscarPrecio` que use **Búsqueda Lineal** para encontrar si un precio específico existe en el inventario.
4. **Salida:** Mostrar el arreglo desordenado, luego ordenado, y el resultado de la búsqueda.

---

## 💡 Referencia de Código
Revisa la implementación de algoritmos de intercambio (swap) y paso de parámetros en:
`~/programacion1/programacion1-umg/01_ejemplos/ejemplo_algoritmos`

---

## 🚀 Instrucciones
1. Actualiza: `git pull`
2. Genera: `crear-lab 10`
3. Carpeta de trabajo: `~/programacion1/trabajos/lab10_estudiante`
