using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumas_o_diferencias_de_cubos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la expresión en el siguiente formato (a^3 +/- b^3): ");
            string expresion = Console.ReadLine();

            int a = int.Parse(expresion.Substring(0, expresion.IndexOf('^')));
            int b = int.Parse(expresion.Substring(expresion.IndexOf('+') + 1,expresion.IndexOf("+") - 1));
            char signo = expresion[expresion.IndexOf("^") + 2];

            int resultado = 0;
            if (signo == '+')
            {
                resultado = (int)(Math.Pow(a, 3) + Math.Pow(b, 3));
            }
            else if (signo == '-')
            {
                resultado = (int)(Math.Pow(a, 3) - Math.Pow(b, 3));
            }
            Console.WriteLine("El resultado de la expresion {0} es: {1}", expresion, resultado);
        }
    }
}
