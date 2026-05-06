/*
 * ======================================================================================
 * PROYECTO: Auditoría Logística - Búsqueda Recursiva en Matriz 5x5
 * DESCRIPCIÓN: Implementación de búsqueda sin iteradores (Recursión pura).
 * ======================================================================================
 */
using System;

namespace LogisticaGlobal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] almacen = new int[5, 5];
            Random rnd = new Random();

            // Llenado de matriz (Permitido iteración solo para inicialización)
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    almacen[i, j] = rnd.Next(100, 999);

            Console.WriteLine(">>> SISTEMA DE AUDITORÍA LOGÍSTICA <<<");
            Console.Write("Ingrese el código de producto a buscar: ");
            int objetivo = int.Parse(Console.ReadLine());

            // Invocación del método recursivo
            bool encontrado = BuscarRecursivo(almacen, objetivo, 0, 0);

            Console.WriteLine(encontrado ? "\nESTADO: Producto localizado en la red." : "\nESTADO: Producto inexistente.");
            Console.ReadKey();
        }

        // MÉTODO RECURSIVO: La lógica del "Divide y Vencerás"
        static bool BuscarRecursivo(int[,] m, int obj, int f, int c)
        {
            // CASO BASE 1: Salida de límites (el producto no está)
            if (f >= m.GetLength(0)) return false;

            // CASO BASE 2: Producto encontrado
            if (m[f, c] == obj) return true;

            // CASO RECURSIVO: Avanzar en la matriz
            // Si llegamos a la última columna, saltamos a la siguiente fila
            if (c + 1 >= m.GetLength(1))
                return BuscarRecursivo(m, obj, f + 1, 0);
            
            // Si no, avanzamos a la siguiente columna
            return BuscarRecursivo(m, obj, f, c + 1);
        }
    }
}