/*
 * ======================================================================================
 * UNIVERSIDAD MARIANO GÁLVEZ DE GUATEMALA
 * FACULTAD DE INGENIERÍA EN SISTEMAS
 * PROYECTO: Sistema de Gestión "Auto-Service Portales"
 * REQUISITOS TÉCNICOS: Lógica centralizada en Main, sin funciones externas.
 * ESTRUCTURAS: do-while, while, for, switch, if anidados.
 * ======================================================================================
 */

using System;

namespace AutoServicePortales
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcionMenu;

            // 1. DO-WHILE: Control del flujo principal del programa
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("==========================================================");
                Console.WriteLine("          SISTEMA DE GESTIÓN AUTO-SERVICE PORTALES        ");
                Console.WriteLine("==========================================================");
                Console.ResetColor();
                Console.WriteLine("1. Registrar Nuevo Servicio de Vehículo");
                Console.WriteLine("2. Salir del Sistema");
                Console.Write("\nSeleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcionMenu))
                {
                    opcionMenu = 0; // Reset para invalidar
                }

                if (opcionMenu == 1)
                {
                    Console.Clear();
                    Console.WriteLine(">>> INGRESO DE DATOS DEL SERVICIO <<<\n");

                    // 2. WHILE: Validación rigurosa de costo positivo
                    double costoBase = 0;
                    Console.Write("Ingrese el costo base del servicio: Q");
                    while (!double.TryParse(Console.ReadLine(), out costoBase) || costoBase <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("ERROR: El costo debe ser un valor numérico superior a cero. Reintente: Q");
                        Console.ResetColor();
                    }

                    // 3. SWITCH: Selección del tipo de motor
                    Console.WriteLine("\nTipos de Motor:");
                    Console.WriteLine("1. Gasolina | 2. Diesel | 3. Híbrido");
                    Console.Write("Seleccione una opción: ");
                    string motorDesc = "";
                    int motorOp = int.Parse(Console.ReadLine());
                    switch (motorOp)
                    {
                        case 1: motorDesc = "Gasolina"; break;
                        case 2: motorDesc = "Diesel"; break;
                        case 3: motorDesc = "Híbrido"; break;
                        default: motorDesc = "Genérico / No definido"; break;
                    }

                    // 4. FOR: Registro de repuestos mediante iteración fija
                    Console.Write("\n¿Cantidad de repuestos utilizados?: ");
                    int cantRepuestos = int.Parse(Console.ReadLine());
                    string listaRepuestos = "";
                    for (int i = 1; i <= cantRepuestos; i++)
                    {
                        Console.Write($"Nombre del repuesto #{i}: ");
                        string nombreRepuesto = Console.ReadLine();
                        listaRepuestos += (i == 1 ? "" : ", ") + nombreRepuesto;
                    }

                    // 5. IF ANIDADOS: Lógica compleja de beneficios y descuentos
                    Console.Write("\nIngrese el kilometraje del vehículo: ");
                    double km = double.Parse(Console.ReadLine());
                    Console.Write("¿Es cliente frecuente? (S/N): ");
                    bool esFrecuente = Console.ReadLine().Trim().ToUpper() == "S";

                    double tasaDescuento = 0;
                    if (km > 20000)
                    {
                        if (esFrecuente)
                        {
                            tasaDescuento = 0.15; // 15% por desgaste y fidelidad
                        }
                        else
                        {
                            tasaDescuento = 0.05; // 5% solo por desgaste
                        }
                    }
                    else
                    {
                        if (esFrecuente)
                        {
                            tasaDescuento = 0.10; // 10% por fidelidad (bajo kilometraje)
                        }
                        // Sin descuento si no cumple condiciones
                    }

                    // Cálculos finales de facturación
                    double montoDescuento = costoBase * tasaDescuento;
                    double totalFinal = costoBase - montoDescuento;

                    // Salida de resultados profesional
                    Console.WriteLine("\n==========================================================");
                    Console.WriteLine("               DETALLE DE ORDEN DE SERVICIO               ");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine($"Motor:      {motorDesc}");
                    Console.WriteLine($"Repuestos:  {(listaRepuestos == "" ? "Ninguno" : listaRepuestos)}");
                    Console.WriteLine($"Costo Base: Q{costoBase:N2}");
                    Console.WriteLine($"Descuento:  {tasaDescuento * 100}% (Q{montoDescuento:N2})");
                    Console.WriteLine("----------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"TOTAL NETO: Q{totalFinal:N2}");
                    Console.ResetColor();
                    Console.WriteLine("==========================================================");
                    
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
                else if (opcionMenu == 2)
                {
                    Console.WriteLine("\nCerrando el sistema de gestión. Operación finalizada.");
                }
                else
                {
                    Console.WriteLine("\nEntrada no reconocida. Presione una tecla para reintentar...");
                    Console.ReadKey();
                }

            } while (opcionMenu != 2);
        }
    }
}