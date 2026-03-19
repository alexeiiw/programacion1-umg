# GUÍA 03 - OPERADORES LÓGICOS

## 🎯 Objetivo
Aprender a combinar varias comparaciones en una sola decisión utilizando los operadores lógicos **AND**, **OR** y **NOT**.

---

## ⚡ Los Tres Mosqueteros de la Lógica

A veces, una sola comparación no es suficiente. Necesitamos evaluar varias cosas al mismo tiempo:

### 1. El Operador AND (`&&`) - "Todo o nada"
Solo es **Verdadero** si **TODAS** las condiciones se cumplen.
- *Ejemplo:* Para entrar a la universidad necesitas: (Tener Título **Y** Pagar Inscripción). 
- Si falta uno, no entras.

### 2. El Operador OR (`||`) - "Cualquiera sirve"
Es **Verdadero** si al menos **UNA** de las condiciones se cumple.
- *Ejemplo:* Para entrar al examen necesitas: (Llevar Carnet **O** Llevar DPI).
- Con que lleves uno de los dos, puedes pasar.

### 3. El Operador NOT (`!`) - "El mundo al revés"
Invierte el resultado. Lo que es Verdadero lo vuelve Falso y viceversa.
- *Ejemplo:* `!(edad < 18)` es lo mismo que decir "No es menor de edad".

---

## 🧭 El Reto: Sistema de Becas 2.0 (Optimizado)

Vamos a mejorar el sistema anterior. Ahora los requisitos para la "Beca de Excelencia" son más estrictos pero el código será más limpio:

**Requisitos para aplicar:**
1.  El promedio debe ser **mayor o igual a 90**.
2.  **Y ADEMÁS**, las faltas deben ser **menores o iguales a 2**.

**Lógica del programa:**
- **SI** cumple ambas (Promedio >= 90 **Y** Faltas <= 2): Mostrar "Felicidades, aplicas a la beca".
- **SI NO**: Mostrar "Lo sentimos, no cumples con todos los requisitos".

---

## 💡 Referencia de Código
Si quieres ver cómo se escriben los símbolos `&&` y `||` en C#, revisa:
`~/programacion1/programacion1-umg/01_ejemplos/ejemplo_operadores_logicos`

---

## 🚀 Instrucciones
1. Ejecuta: `crear-lab 03`
2. Ve a: `~/programacion1/trabajos/lab03_estudiante`
3. Resuelve el reto en `Program.cs`.
