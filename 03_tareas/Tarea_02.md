# Resolución: Tarea 02 - El Protocolo de Autodestrucción "Rogue-Portales"

**Situación:** Resolver la llave lógica maestra para detener la IA.
**Expresión:** ¬(P ∨ Q) ⇔ (R ∧ ¬P)

---

### 1. TRADUCCIÓN AL LENGUAJE HUMANO
La expresión es **VERDADERA** bajo dos condiciones técnicas principales:

1.  **Silencio del Sistema:** Tanto el núcleo de energía está estable (P) como el ventilador está encendido (Q) deben ser **FALSOS**, y al mismo tiempo, debe haber una brecha de seguridad (R) mientras el núcleo sigue inestable (¬P).
2.  **Equilibrio de Fallos:** O bien el sistema de emergencia (P o Q) está activado y no hay una brecha de seguridad con el núcleo inestable.

En resumen: El código de desactivación se activa si el estado de los sistemas críticos (P y Q) es equivalente al estado de amenaza externa filtrada por la estabilidad del núcleo.

---

### 2. TABLA DE VERDAD
Para resolver `¬(P ∨ Q) ⇔ (R ∧ ¬P)`, desglosamos las 8 combinaciones:

| P | Q | R | (P ∨ Q) | **¬(P ∨ Q)** | ¬P | **(R ∧ ¬P)** | **RESULTADO (⇔)** |
|:---:|:---:|:---:|:---:|:---:|:---:|:---:|:---:|
| V | V | V | V | **F** | F | **F** | **V** |
| V | V | F | V | **F** | F | **F** | **V** |
| V | F | V | V | **F** | F | **F** | **V** |
| V | F | F | V | **F** | F | **F** | **V** |
| F | V | V | V | **F** | V | **V** | **F** |
| F | V | F | V | **F** | V | **F** | **V** |
| F | F | V | F | **V** | V | **V** | **V** |
| F | F | F | F | **V** | V | **F** | **F** |

---

### 3. SIMULACIÓN DE CRISIS
**Datos del sistema:**
* **P = V** (Núcleo estable)
* **Q = F** (Ventilador apagado)
* **R = V** (Brecha detectada)

**Evaluación:**
1. ¬(V ∨ F) = ¬(V) = **Falso**
2. (V ∧ ¬V) = (V ∧ F) = **Falso**
3. Falso ⇔ Falso = **Verdadero**

**Respuesta:** **SÍ se logra detener la IA.** *Justificación:* Según la tercera fila de nuestra tabla de verdad, cuando P es verdadero, Q es falso y R es verdadero, la equivalencia final resulta en **Verdadero**, lo que activa la llave maestra de desactivación.

---

### 4. PROGRAMA DE EVALUACIÓN (C#)

```csharp
using System;

namespace ProtocoloRoguePortales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE EMERGENCIA: SEDE PORTALES ===");
            
            // Sensores reportados en la crisis
            bool P = true;  // Núcleo estable
            bool Q = false; // Ventilador apagado
            bool R = true;  // Brecha detectada

            // Expresión: ¬ (P ∨ Q) ⇔ (R ∧ ¬P)
            // En C#, el bicondicional (⇔) se representa con el operador de igualdad (==)
            
            bool parteIzquierda = !(P || Q);
            bool parteDerecha = (R && !P);
            
            bool llaveMaestra = (parteIzquierda == parteDerecha);

            Console.WriteLine($"\nSensor P (Núcleo): {P}");
            Console.WriteLine($"Sensor Q (Ventilador): {Q}");
            Console.WriteLine($"Sensor R (Brecha): {R}");
            
            Console.WriteLine("\n-------------------------------------------");
            if (llaveMaestra)
            {
                Console.WriteLine("RESULTADO: ¡LLAVE MAESTRA CORRECTA!");
                Console.WriteLine("ESTADO: IA Rogue-Portales DETENIDA.");
            }
            else
            {
                Console.WriteLine("RESULTADO: LLAVE INCORRECTA.");
                Console.WriteLine("ESTADO: Autodestrucción en curso...");
            }
        }
    }
}
