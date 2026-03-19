# GUÍA 07 - ENTRADAS MÚLTIPLES Y VALIDACIÓN

## 🎯 Objetivo
Aprender a capturar diversos tipos de datos en un solo flujo y asegurar que el programa no se detenga si el usuario ingresa datos incorrectos.

---

## 📥 1. Captura de Datos Múltiples
Un programa real rara vez pide una sola cosa. Normalmente necesitamos un "Perfil":
- **Texto:** Nombre, Apellido, Correo (`string`).
- **Números Enteros:** Edad, Cantidad (`int`).
- **Números Decimales:** Precio, Peso, Estatura (`double` o `decimal`).
- **Booleanos:** ¿Es graduado?, ¿Tiene seguro? (`bool`).

**Regla de oro:** C# siempre lee todo como **Texto (string)**. Es tu responsabilidad convertirlo (parsear) al tipo de dato correcto.

---

## 🛡️ 2. Validaciones Básicas
¿Qué pasa si pides una edad y el usuario escribe "Hola"? El programa "explota" (Crash).
Para evitarlo, usamos validaciones antes de procesar:

1. **Validación de Rango:** ¿La edad es mayor a 0 y menor a 120?
2. **Validación de Formato:** ¿El correo contiene una '@'?
3. **Validación de Existencia:** ¿El usuario dejó el nombre vacío?

---

## 🧭 El Reto: Registro de Atletas UMG

Vas a crear un sistema de inscripción para una carrera universitaria:

1. **Captura:** Solicitar Nombre completo, Edad, y Tiempo récord (en minutos).
2. **Validación:** - Si la edad es menor a 15 años, mostrar: "Categoría Juvenil no disponible".
   - Si el tiempo récord es negativo, mostrar: "Error: El tiempo no puede ser menor a cero".
3. **Proceso:**
   - Si los datos son válidos, mostrar un resumen del atleta:
     *"Atleta [Nombre] registrado con éxito. Categoría: [Adulto/Senior]."*

---

## 💡 Referencia de Código
Mira cómo pedir varios datos seguidos y validarlos con `if` en:
`~/programacion1/programacion1-umg/01_ejemplos/ejemplo_entradas_multiples`

---

## 🚀 Instrucciones
1. `git pull`
2. `crear-lab 07`
3. Trabaja en: `~/programacion1/trabajos/lab07_estudiante`
