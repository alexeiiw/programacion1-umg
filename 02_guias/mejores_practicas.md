# 🏆 MEJORES PRÁCTICAS DE PROGRAMACIÓN

Escribir código que funcione es fácil; escribir código que otros entiendan es el verdadero reto.

## 1. Nomenclatura (Nombres)
- **Variables:** Usa `camelCase` (empezar en minúscula, luego mayúscula).
  - ✅ `int edadMinima = 18;`
  - ❌ `int e = 18;`
- **Clases:** Usa `PascalCase` (empezar con Mayúscula).
  - ✅ `class CalculadoraBeca`

## 2. Indentación (Sangría)
El código debe tener "aire". Todo lo que esté dentro de llaves `{ }` debe llevar un espacio de tabulación (TAB) hacia la derecha.

## 3. Comentarios (El "Por qué" vs el "Qué") 📝
Los comentarios son notas para humanos, la computadora los ignora.
- **No comentes lo obvio:** `int x = 5; // declara x` (Esto es innecesario).
- **Comenta la intención:** `// Usamos OR (||) porque el banco acepta cualquiera de las dos garantías` (Esto es valioso).
- **Comentarios de bloque:** Úsalos al inicio de métodos complejos para explicar qué se espera lograr.

## 4. Validaciones
Nunca asumas que el usuario es perfecto. Antes de hacer un cálculo, verifica que los números sean lógicos (ej. que la edad no sea -5).
