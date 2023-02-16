using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcualdora_de_año_bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor ingrese el año que desea consultar");
            int año = Convert.ToInt32(Console.ReadLine());

            if (EsBisiesto(año))
            {
                Console.WriteLine("{0} es un año bisiesto.", año);
            }
            else
            {
                Console.WriteLine("{0} no es un año bisiesto.", año);
            }
        }

        static bool EsBisiesto(int año)
        {
            if ((año % 4 == 0 && año % 100 !=0) || año % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
