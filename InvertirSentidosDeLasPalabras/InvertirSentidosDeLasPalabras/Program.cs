using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertirSentidosDeLasPalabras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese la cadena de texto:");
            string cadena = Console.ReadLine();

            string[] palabras = cadena.Split(' ');

            Array.Reverse(palabras);

            string resultado = string.Join(" ", palabras);

            Console.WriteLine("La cadena invertida es: {0}", resultado);
            Console.Read();
        }
    }
}
