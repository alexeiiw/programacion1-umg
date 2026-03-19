# GUÍA 02 - ESTRUCTURAS DE CONTROL Y COMPARACIÓN

## 🎯 Objetivo
Aprender a programar el "cerebro" de una aplicación: la capacidad de tomar decisiones basadas en datos y comparaciones lógicas.

---

## ⚖️ 1. Operadores de Comparación
Para que una computadora decida, primero debe comparar. El resultado de estas preguntas es siempre un valor Booleano (`true` o `false`).

| Si quieres saber si... | Símbolo | Ejemplo Lógico |
| :--- | :---: | :--- |
| Son exactamente iguales | `==` | ¿Clave ingresada es igual a la correcta? |
| Son diferentes | `!=` | ¿El usuario es distinto de "Invitado"? |
| Es estrictamente mayor | `>` | ¿La edad es mayor a 18? |
| Es estrictamente menor | `<` | ¿El precio es menor a 10.00? |
| Es mayor o igual | `>=` | ¿La nota es 61 o más? |
| Es menor o igual | `<=` | ¿Las faltas son 3 o menos? |

---

## 🚦 2. Tipos de Decisiones

### A. Decisión Simple (`if`)
Se usa cuando solo nos interesa un camino. Si no se cumple, el programa sigue de largo.
* *Ejemplo:* Si el usuario es VIP, mostrar un saludo especial.

### B. Decisión Alternativa (`if - else`)
Se usa cuando hay dos caminos obligatorios. O pasa una cosa, o pasa la otra.
* *Ejemplo:* Si el pago fue aprobado, "Generar factura"; de lo contrario, "Mostrar error".

### C. Escalera de Decisiones (`else if`)
Se usa cuando hay múltiples opciones que se excluyen entre sí. Se revisan de arriba hacia abajo hasta encontrar la primera que sea cierta.
* *Ejemplo:* Clasificar una temperatura como "Frío", "Templado" o "Calor".

### D. Decisiones Anidadas (Preguntas dentro de otras)
Se usa cuando una decisión depende del éxito de una anterior.
* *Ejemplo:* **SI** el usuario inició sesión:
    - (Preguntar de nuevo) **SI** tiene saldo, permitir compra.
    - **SI NO**, pedir recarga.
* **SI NO** inició sesión: No se le pregunta nada del saldo.

---

## 🧭 El Reto: Sistema de Becas UMG

Debes programar la lógica para un sistema automático de becas en la sede:

1.  **Ingreso de Datos:** Solicitar el promedio (0-100) y el ingreso familiar mensual.
2.  **Clasificación de Rendimiento:**
    - Menos de 70: "Rendimiento Bajo" (No aplica a beca).
    - 70 a 89: "Rendimiento Estándar".
    - 90 o más: "Rendimiento Excelente".
3.  **Filtro Socioeconómico (Anidado):**
    - **SOLO SI** el rendimiento es "Excelente", preguntar el ingreso familiar.
    - Si el ingreso es menor a Q3,000: Mostrar "¡Beca Completa asignada!".
    - Si el ingreso es mayor o igual a Q3,000: Mostrar "Beca Parcial asignada".

---

## 💡 ¿Dónde ver un ejemplo de código?

Si tienes dudas sobre cómo escribir los paréntesis `()`, las llaves `{}` o el orden de los `else if`, revisa el código de referencia en tu repositorio:

📁 **Ruta:** `~/programacion1/programacion1-umg/01_ejemplos/ejemplo_if_completo`

---

## 🚀 Instrucciones para trabajar
1.  Asegúrate de estar actualizado: `git pull` dentro del repositorio.
2.  Genera tu laboratorio: `crear-lab 02`
3.  Entra a tu zona de trabajo: `cd ~/programacion1/trabajos/lab02_estudiante`
4.  Abre el código: `code .`
5.  Resuelve el reto en `Program.cs`.

---

## ⚠️ Reglas de Oro
- **No copies:** Escribe el código línea por línea para entender la sintaxis.
- **Prueba todo:** Ingresa datos que activen todos los caminos (un promedio de 50, uno de 95, un ingreso alto, un ingreso bajo).
- **Lee los errores:** Si `dotnet run` falla, lee el mensaje en la terminal antes de pedir ayuda.
