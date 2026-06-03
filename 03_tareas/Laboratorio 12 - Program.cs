using System;
using Microsoft.Data.Sqlite;

namespace Laboratorio12
{
    class Program
    {
        static string cadenaConexion = "Data Source=control_parqueo.db";

        static void Main(string[] args)
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("  SISTEMA DE CONTROL DE PARQUEO AUTOMATIZADO - L12  ");
            Console.WriteLine("====================================================\n");

            // 1. CREATE TABLE
            CrearEsquemaBD();

            // 2. INSERT (Evento: Ingreso de vehículo por sensor de entrada)
            RegistrarIngreso(105, "P-789XYZ", "16:00");

            // 3. SELECT (Evento: Consulta para panel luminoso exterior)
            MostrarEspaciosOcupados();

            // 4. UPDATE (Evento: Pago registrado en caja central)
            ProcesarPago(105);

            // 5. DELETE (Evento: Vehículo cruza aguja de salida y libera espacio)
            LiberarEspacioSalida(105);

            Console.WriteLine("\n====================================================");
            Console.WriteLine("   EJECUCIÓN DEL CICLO DE EVENTOS FINALIZADA        ");
            Console.WriteLine("====================================================");
        }

        static void CrearEsquemaBD()
        {
            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = @"
                    CREATE TABLE IF NOT EXISTS OcupacionParqueo (
                        EspacioId INTEGER PRIMARY KEY,
                        Placa TEXT NOT NULL,
                        HoraEntrada TEXT NOT NULL,
                        Estado TEXT NOT NULL
                    );";
                
                using (var comando = new SqliteCommand(sql, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }
            Console.WriteLine("⚙️ [SISTEMA]: Tabla 'OcupacionParqueo' verificada/creada con éxito.");
        }

        static void RegistrarIngreso(int espacio, string placa, string hora)
        {
            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "INSERT INTO OcupacionParqueo (EspacioId, Placa, HoraEntrada, Estado) VALUES (@espacio, @placa, @hora, 'Estacionado')";
                
                using (var comando = new SqliteCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@espacio", espacio);
                    comando.Parameters.AddWithValue("@placa", placa);
                    comando.Parameters.AddWithValue("@hora", hora);
                    comando.ExecuteNonQuery();
                }
            }
            Console.WriteLine($"🚗 [SENSOR ENTRADA]: Vehículo {placa} ingresó al Espacio {espacio}.");
        }

        static void MostrarEspaciosOcupados()
        {
            Console.WriteLine("\n🖥️ [PANEL INFORMATIVO OCURRIDO] - Espacios Ocupados:");
            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "SELECT EspacioId, Placa, Estado FROM OcupacionParqueo";
                
                using (var comando = new SqliteCommand(sql, conexion))
                using (var lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Console.WriteLine($"   -> Espacio: {lector.GetInt32(0)} | Placa: {lector.GetString(1)} | Estado: {lector.GetString(2)}");
                    }
                }
            }
        }

        static void ProcesarPago(int espacio)
        {
            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "UPDATE OcupacionParqueo SET Estado = 'Autorizado para Salir' WHERE EspacioId = @espacio";
                
                using (var comando = new SqliteCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@espacio", espacio);
                    comando.ExecuteNonQuery();
                }
            }
            Console.WriteLine($"\n💵 [CAJA CENTRAL]: Pago recibido para el Espacio {espacio}. Estado actualizado.");
        }

        static void LiberarEspacioSalida(int espacio)
        {
            using (var conexion = new SqliteConnection(cadenaConexion))
            {
                conexion.Open();
                string sql = "DELETE FROM OcupacionParqueo WHERE EspacioId = @espacio";
                
                using (var comando = new SqliteCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@espacio", espacio);
                    comando.ExecuteNonQuery();
                }
            }
            Console.WriteLine($"🏁 [SENSOR SALIDA]: El vehículo evacuó la aguja. Espacio {espacio} se encuentra LIBRE de nuevo.");
        }
    }
}