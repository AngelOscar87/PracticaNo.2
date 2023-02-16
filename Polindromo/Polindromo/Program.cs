using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polindromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese la cadana de texto");
            string cadena = Console.ReadLine();

            cadena = cadena.Replace(" ", "").ToLower();

            char[] chars= cadena.ToCharArray();
            Array.Reverse(chars);
            string cadenaInversa = new string(chars);

            if (cadena == cadenaInversa)
            {
                Console.WriteLine("La cadena ingresada es un palíndormo");
            }
            else 
            {
                Console.WriteLine("La cadena ingresada no es un palíndromo.");
            }

        }
    }
}
