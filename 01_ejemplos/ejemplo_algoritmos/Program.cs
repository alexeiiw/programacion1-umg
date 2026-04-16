using System;

namespace LaboratorioAlgoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("    ALGORITMOS DE ARREGLOS (GUÍA 10)    ");
            Console.WriteLine("========================================\n");

            // 1. Inicialización
            int[] inventario = new int[10];
            
            // 2. Llamada a función para llenar el arreglo
            LlenarArreglo(inventario);
            Console.WriteLine("Inventario original (desordenado):");
            MostrarArreglo(inventario);

            // 3. Ordenamiento por Método de Burbuja
            Console.WriteLine("\nOrdenando inventario...");
            OrdenarBurbuja(inventario);
            MostrarArreglo(inventario);

            // 4. Búsqueda Lineal
            Console.Write("\nIngrese el precio que desea buscar: ");
            int buscar = int.Parse(Console.ReadLine());
            
            int posicion = BuscarLineal(inventario, buscar);

            if (posicion != -1)
                Console.WriteLine($"✅ ¡Encontrado! El precio {buscar} está en la posición {posicion}.");
            else
                Console.WriteLine("❌ El precio no existe en el inventario.");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        // --- MÉTODOS (ARREGLOS A FUNCIONES) ---

        static void LlenarArreglo(int[] arreglo)
        {
            Random azar = new Random();
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = azar.Next(10, 100);
            }
        }

        static void MostrarArreglo(int[] arreglo)
        {
            foreach (int item in arreglo)
            {
                Console.Write($"[{item}] ");
            }
            Console.WriteLine();
        }

        static void OrdenarBurbuja(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        // Intercambio (Swap)
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }
        }

        static int BuscarLineal(int[] arreglo, int valor)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == valor) return i; // Retorna el índice si lo encuentra
            }
            return -1; // Retorna -1 si no existe
        }
    }
}
