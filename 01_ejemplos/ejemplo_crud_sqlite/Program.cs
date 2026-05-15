using System;
using Microsoft.Data.Sqlite;

namespace LaboratorioCRUD
{
    class Program
    {
        // Ruta de la base de datos SQLite
        static string rutaBD = "tareas.db";
        static string cadenaConexion = $"Data Source={rutaBD}";

        static void Main(string[] args)
        {
            Console.WriteLine("========================================");
            Console.WriteLine("   SISTEMA CRUD - LISTA DE TAREAS      ");
            Console.WriteLine("========================================\n");

            // Inicializar la base de datos
            InicializarBaseDatos();

            // Menú principal
            int opcion = 0;
            do
            {
                MostrarMenu();
                Console.Write("\nSeleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        AgregarTarea();
                        break;
                    case 2:
                        ListarTareas();
                        break;
                    case 3:
                        MarcarTareaCompletada();
                        break;
                    case 4:
                        EliminarTarea();
                        break;
                    case 5:
                        Console.WriteLine("\n¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("\n⚠️  Opción inválida. Intente de nuevo.");
                        break;
                }

                if (opcion != 5)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcion != 5);

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        /// <summary>
        /// Crea la base de datos y la tabla si no existen
        /// Inserta datos de ejemplo la primera vez
        /// </summary>
        static void InicializarBaseDatos()
        {
            // Verificar si la base de datos ya existe
            bool primeraVez = !System.IO.File.Exists(rutaBD);

            // Crear conexión
            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();

                // Crear la tabla si no existe
                string sqlCrearTabla = @"
                    CREATE TABLE IF NOT EXISTS Tareas (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Descripcion TEXT NOT NULL,
                        Completada INTEGER NOT NULL DEFAULT 0
                    )";

                using (var comando = new SqliteCommand(sqlCrearTabla, conexion))
                {
                    comando.ExecuteNonQuery();
                }

                // Si es la primera vez, insertar datos de ejemplo
                if (primeraVez)
                {
                    string[] tareasEjemplo = {
                        "Estudiar programación en C#",
                        "Completar laboratorio de CRUD",
                        "Practicar con bases de datos SQLite"
                    };

                    foreach (string tarea in tareasEjemplo)
                    {
                        string sqlInsertar = "INSERT INTO Tareas (Descripcion, Completada) VALUES (@desc, 0)";
                        using (var comando = new SqliteCommand(sqlInsertar, conexion))
                        {
                            comando.Parameters.AddWithValue("@desc", tarea);
                            comando.ExecuteNonQuery();
                        }
                    }

                    Console.WriteLine("✅ Base de datos creada con datos de ejemplo.\n");
                }
            }
        }

        /// <summary>
        /// Muestra el menú de opciones
        /// </summary>
        static void MostrarMenu()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("              MENU PRINCIPAL            ");
            Console.WriteLine("========================================");
            Console.WriteLine("  1. Agregar nueva tarea");
            Console.WriteLine("  2. Ver todas las tareas");
            Console.WriteLine("  3. Marcar tarea como completada");
            Console.WriteLine("  4. Eliminar tarea");
            Console.WriteLine("  5. Salir");
            Console.WriteLine("========================================");
        }

        /// <summary>
        /// CREATE - Agregar una nueva tarea
        /// </summary>
        static void AgregarTarea()
        {
            Console.WriteLine("\n--- AGREGAR NUEVA TAREA ---");
            Console.Write("Descripción de la tarea: ");
            string descripcion = Console.ReadLine();

            // Validar que no esté vacía
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                Console.WriteLine("\n⚠️  La descripción no puede estar vacía.");
                return;
            }

            // Insertar en la base de datos
            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "INSERT INTO Tareas (Descripcion, Completada) VALUES (@desc, 0)";

                using (var comando = new SqliteCommand(sql, conexion))
                {
                    // Los parámetros evitan problemas de seguridad (SQL Injection)
                    comando.Parameters.AddWithValue("@desc", descripcion);
                    comando.ExecuteNonQuery();
                }
            }

            Console.WriteLine("\n✅ Tarea agregada exitosamente.");
        }

        /// <summary>
        /// READ - Listar todas las tareas
        /// </summary>
        static void ListarTareas()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("         LISTA DE TAREAS                ");
            Console.WriteLine("========================================");

            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "SELECT Id, Descripcion, Completada FROM Tareas ORDER BY Id";

                using (var comando = new SqliteCommand(sql, conexion))
                using (var lector = comando.ExecuteReader())
                {
                    bool hayTareas = false;

                    while (lector.Read())
                    {
                        hayTareas = true;
                        int id = lector.GetInt32(0);
                        string descripcion = lector.GetString(1);
                        bool completada = lector.GetInt32(2) == 1;

                        // Mostrar con formato visual
                        string estado = completada ? "[✓]" : "[ ]";
                        Console.WriteLine($"{estado} {id}. {descripcion}");
                    }

                    if (!hayTareas)
                    {
                        Console.WriteLine("\n📋 No hay tareas registradas.");
                    }
                }
            }

            Console.WriteLine("========================================");
        }

        /// <summary>
        /// UPDATE - Marcar una tarea como completada
        /// </summary>
        static void MarcarTareaCompletada()
        {
            Console.WriteLine("\n--- MARCAR TAREA COMO COMPLETADA ---");
            
            // Mostrar primero las tareas pendientes
            MostrarTareasPendientes();

            Console.Write("\nIngrese el ID de la tarea a completar: ");
            int id = int.Parse(Console.ReadLine());

            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();
                
                // Actualizar el estado de la tarea
                string sql = "UPDATE Tareas SET Completada = 1 WHERE Id = @id";

                using (var comando = new SqliteCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("\n✅ Tarea marcada como completada.");
                    }
                    else
                    {
                        Console.WriteLine("\n⚠️  No se encontró una tarea con ese ID.");
                    }
                }
            }
        }

        /// <summary>
        /// DELETE - Eliminar una tarea
        /// </summary>
        static void EliminarTarea()
        {
            Console.WriteLine("\n--- ELIMINAR TAREA ---");
            
            // Mostrar las tareas actuales
            ListarTareas();

            Console.Write("\nIngrese el ID de la tarea a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "DELETE FROM Tareas WHERE Id = @id";

                using (var comando = new SqliteCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    int filasAfectadas = comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        Console.WriteLine("\n✅ Tarea eliminada exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("\n⚠️  No se encontró una tarea con ese ID.");
                    }
                }
            }
        }

        /// <summary>
        /// Método auxiliar para mostrar solo tareas pendientes
        /// </summary>
        static void MostrarTareasPendientes()
        {
            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "SELECT Id, Descripcion FROM Tareas WHERE Completada = 0 ORDER BY Id";

                using (var comando = new SqliteCommand(sql, conexion))
                using (var lector = comando.ExecuteReader())
                {
                    bool hayPendientes = false;
                    Console.WriteLine("\nTareas pendientes:");

                    while (lector.Read())
                    {
                        hayPendientes = true;
                        int id = lector.GetInt32(0);
                        string descripcion = lector.GetString(1);
                        Console.WriteLine($"  [ ] {id}. {descripcion}");
                    }

                    if (!hayPendientes)
                    {
                        Console.WriteLine("  ¡No hay tareas pendientes!");
                    }
                }
            }
        }
    }
}
