using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSemanas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la primera semana esto en formato dd/mm/aaaa: ");
            DateTime fecha1 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda semana esto en formato dd/mm/aaaa ");
            DateTime fecha2 = DateTime.Parse(Console.ReadLine());

            TimeSpan diferencia = fecha2 - fecha1;
            int cantSemanas = (int)diferencia.TotalDays / 7;

            Console.WriteLine("Entre {0} y {1} hay {2} semanas.", fecha1.ToShortDateString(), fecha2.ToShortDateString(), cantSemanas);
            Console.Read();
        }
    }
}
