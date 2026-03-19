# GUÍA 06 - CONTADORES Y ACUMULADORES

## 🎯 Objetivo
Aprender a gestionar datos que cambian a medida que un ciclo se repite: contar sucesos y sumar cantidades.

---

## 🧮 1. El Contador (Conteo)
Un **contador** es una variable que aumenta en una cantidad fija (usualmente +1) cada vez que ocurre algo.
- **Uso:** "¿Cuántos alumnos aprobaron?", "¿Cuántas veces se equivocó el usuario?".
- **Lógica:** `contador = contador + 1;` (o de forma resumida `contador++;`).

## 💰 2. El Acumulador (Sumatorias)
Un **acumulador** es una variable que aumenta en una cantidad **variable**. Sirve para "reunir" un total.
- **Uso:** "Suma total de una factura", "Promedio de notas", "Total de ventas del día".
- **Lógica:** `acumulador = acumulador + valor_nuevo;` (o resumido `acumulador += valor_nuevo;`).

---

## 🚦 3. Diferencia Visual
Imagina una alcancía:
- El **Contador** te dice cuántas monedas metiste (1, 2, 3...).
- El **Acumulador** te dice cuánto dinero hay en total (Q5 + Q10 + Q1...).



---

## 🧭 El Reto: Sistema de Control de Caja

Vas a simular una caja registradora simple que procese una serie de ventas:

1. **Entrada:** Preguntar al usuario cuántas ventas desea ingresar.
2. **Ciclo:** Usar un `for` que se repita esa cantidad de veces.
3. **Proceso:** - En cada vuelta, pedir el precio del producto.
   - **Acumular** el precio para obtener el gran total.
   - **Contar** cuántos productos cuestan más de Q100.00 (usando un `if` dentro del ciclo).
4. **Salida:** Mostrar el total de la venta y cuántos productos fueron "Premium" (mayores a 100).

---

## 💡 Referencia de Código
Revisa cómo inicializar las variables en 0 antes del ciclo en:
`~/programacion1/programacion1-umg/01_ejemplos/ejemplo_acumuladores`

---

## 🚀 Instrucciones
1. Actualiza: `git pull`
2. Genera: `crear-lab 06`
3. Carpeta de trabajo: `~/programacion1/trabajos/lab06_estudiante`
