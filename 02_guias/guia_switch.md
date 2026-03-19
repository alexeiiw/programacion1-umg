# GUÍA 04 - ESTRUCTURA SELECCIONAR (SWITCH)

## 🎯 Objetivo
Aprender a manejar múltiples opciones de forma limpia y organizada cuando una sola variable puede tomar muchos valores diferentes.

---

## 💡 ¿Qué es el Switch?
Imagina que estás en un ascensor. Presionas un botón y el ascensor decide a qué piso ir. 
- Si presionas 1, va al Piso 1.
- Si presionas 2, va al Piso 2.
- Si presionas un botón que no existe, no hace nada o da error.

En lugar de usar muchos `if else if` que ensucian el código, usamos `switch`, que es más rápido de leer y escribir.

---

## 🧱 Componentes del Switch

1. **La Variable:** Es lo que queremos evaluar (ej. el número de piso).
2. **Caso (case):** Es el valor específico que estamos buscando.
3. **Ruptura (break):** Es la instrucción que dice: "Ya encontré lo que buscaba, deja de buscar". **¡Es obligatorio!**
4. **Por defecto (default):** Es lo que sucede si ninguno de los casos anteriores se cumplió (el "si no" final).

---

## 🧭 El Reto: Menú de Comida Rápida

Vas a programar el sistema de una pantalla táctil de un restaurante. El usuario debe elegir una opción del menú:

**Opciones del Menú:**
1. **Hamburguesa:** Mostrar "Precio: Q35.00"
2. **Pizza:** Mostrar "Precio: Q45.00"
3. **Ensalada:** Mostrar "Precio: Q30.00"
4. **Cualquier otro número:** Mostrar "Opción no válida, intente de nuevo".

---

## 💡 Referencia de Código
Mira cómo se estructura un switch (paréntesis, llaves y los dos puntos) en:
`~/programacion1/programacion1-umg/01_ejemplos/ejemplo_switch`

---

## 🚀 Instrucciones
1. Actualiza tu repo: `git pull`
2. Ejecuta: `crear-lab 04`
3. Ve a: `~/programacion1/trabajos/lab04_estudiante`
4. Programa la lógica en `Program.cs`.
