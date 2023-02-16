using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fracciones_mixtas___fracciones_comunes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor integrese la fracción mixta");
            Console.WriteLine("Por favor ingreselo en el siguiente formato entero numerador/denumerador");
            Console.WriteLine("Ejemplo: 9 9/9");

            string fraccionMixta = Console.ReadLine();
            string[] partes = fraccionMixta.Split(' ');

            int entero = int.Parse(partes[0]);
            string[] fraccion = partes[1].Split('/');
            int numerador = int.Parse(fraccion[0]);
            int denominador = int.Parse(fraccion[1]);

            int numeradorTotal = (entero + denominador) + numerador;

            Console.WriteLine("La fraccion mixta {0} introducida se convierte en la fracción común: {1}/{2}.", fraccionMixta, numeradorTotal, denominador);
            Console.Read();
        }
    }
}
