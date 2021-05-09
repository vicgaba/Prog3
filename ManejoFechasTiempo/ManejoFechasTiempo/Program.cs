using System;

namespace ManejoFechasTiempo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1, d2;

            Console.WriteLine("Ingrese la primer fecha (YYYY-MM-DD)");
            d1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha final (YYYY-MM-DD)");
            d2 = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine("La cantidad de días entre fechas es: {0}, día de la semana {1}, cantidad de diás de fin de semana {2}",ManejoFechas.obtenerDiasCalendario(d1, d2),d2.DayOfYear,ManejoFechas.obtenerCantFinesDeSemana(d1,d2));
        }
    }
}
