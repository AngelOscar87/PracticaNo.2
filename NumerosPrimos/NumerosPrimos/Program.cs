using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número inicial: ");
            int numeroInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número final: ");
            int numeroDefinido = int.Parse(Console.ReadLine());

            Console.WriteLine("Los números primos entre {0} y {1} son:", numeroInicial, numeroDefinido);

            for (int i = numeroInicial; i <= numeroDefinido; i++)
            {
                bool esPrimo = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo && i !=1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
