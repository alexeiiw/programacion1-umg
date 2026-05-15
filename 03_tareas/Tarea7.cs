using System;
using System.Text;

namespace Tarea7_Cesar_AlexGarcia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CIFRADO CÉSAR (DESPLAZAMIENTO +7) ===");
            Console.Write("Ingrese el texto a cifrar: ");
            string input = Console.ReadLine() ?? "";

            string cifrado = CifrarCesar(input, 7);

            Console.WriteLine($"\nTexto Cifrado: {cifrado}");
        }

        static string CifrarCesar(string texto, int desplazamiento)
        {
            StringBuilder resultado = new StringBuilder();

            foreach (char c in texto)
            {
                if (char.IsLetter(c))
                {
                    // Determinar si es mayúscula o minúscula para el límite ASCII
                    char d = char.IsUpper(c) ? 'A' : 'a';
                    
                    /* Fórmula de Aritmética Modular:
                       C = (x + n) mod 26
                    */
                    char caracterCifrado = (char)((((c + desplazamiento) - d) % 26) + d);
                    resultado.Append(caracterCifrado);
                }
                else
                {
                    // Si no es letra (espacios, números), se queda igual
                    resultado.Append(c);
                }
            }
            return resultado.ToString();
        }
    }
}