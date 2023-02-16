using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TombolaDeLoteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numero1 = random.Next(1, 101);
            int numero2 = random.Next(1, 101);
            int numero3 = random.Next(1, 101);
            
            Console.WriteLine("Sea usted bienvenido a la tombola de la loteria naciona.");
            Console.WriteLine("Los numeros de esta noche son: {0}, {1} y {2}", numero1, numero2, numero3);
            Console.Read();
        }
    }
}
