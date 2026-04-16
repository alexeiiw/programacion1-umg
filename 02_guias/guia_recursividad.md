# GUÍA 08 - RECURSIVIDAD

## 🎯 Objetivo
Comprender cómo una función puede resolverse a sí misma dividiendo un problema grande en piezas pequeñas hasta llegar a un punto de parada.

---

## 🔄 1. ¿Qué es la Recursividad?
La **recursividad** ocurre cuando una función se llama a sí misma dentro de su propio cuerpo. Es una alternativa a los ciclos (`for` o `while`) para resolver problemas que tienen una estructura repetitiva.
- **Uso:** Cálculo de factoriales, potencias, búsqueda en carpetas o estructuras de datos complejas.
- **Lógica:** Se basa en "bajar" niveles de complejidad hasta encontrar una respuesta conocida que detenga el proceso.

## 🛑 2. Los dos Pilares Obligatorios
Para que una función recursiva sea exitosa y no bloquee la memoria del equipo, necesita:
1. **Caso Base:** Es la condición que detiene las llamadas. Es la respuesta más simple (ej. "si el número es 1, ahí termina").
2. **Caso Recursivo:** Es la parte donde la función se llama a sí misma, pero con un valor que la acerca cada vez más al caso base.

---

## 🚦 3. Diferencia Visual
Imagina una **Muñeca Rusa (Matrioshka)**:
- El **Caso Recursivo** es el acto de abrir una muñeca para encontrar otra más pequeña adentro.
- El **Caso Base** es cuando llegas a la muñeca más pequeña que ya no se puede abrir.



---

## 🧭 El Reto: Sumatoria Progresiva

Vas a crear un programa que calcule la suma de todos los números desde un número **N** hasta 1 usando recursividad:

1. **Entrada:** Pedir al usuario un número entero positivo (ej. 5).
2. **Función:** Crear un método llamado `SumarRecursivo(int n)`.
3. **Proceso:** - Si `n == 1`, retornar 1 (**Caso Base**).
   - Si no, retornar `n + SumarRecursivo(n - 1)` (**Caso Recursivo**).
4. **Salida:** Mostrar el resultado final (Para 5, el resultado sería 5+4+3+2+1 = 15).

---

## 💡 Referencia de Código
Revisa la estructura de los métodos y el flujo de la pila de llamadas (stack) en:
`~/programacion1/programacion1-umg/01_ejemplos/ejemplo_recursividad`

---

## 🚀 Instrucciones
1. Actualiza: `git pull`
2. Genera: `crear-lab 08`
3. Carpeta de trabajo: `~/programacion1/trabajos/lab08_estudiante`
