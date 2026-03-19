# 🏆 MEJORES PRÁCTICAS DE PROGRAMACIÓN

Escribir código que funcione es fácil; escribir código que otros entiendan es el verdadero reto.

## 1. Nomenclatura (Nombres)
- **Variables:** Usa `camelCase` (empezar en minúscula, luego mayúscula).
  - ✅ `int edadMinima = 18;`
  - ❌ `int e = 18;` o `int EdAd = 18;`
- **Clases:** Usa `PascalCase` (empezar con Mayúscula).
  - ✅ `class CalculadoraBeca`

## 2. Indentación (Sangría)
El código debe tener "aire". Todo lo que esté dentro de llaves `{ }` debe llevar un espacio de tabulación hacia la derecha.
```csharp
if (true)
{
    // Este espacio es la indentación
    Console.WriteLine("Hola");
}
