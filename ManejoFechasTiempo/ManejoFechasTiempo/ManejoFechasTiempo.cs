using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManejoFechasTiempo
{
    class ManejoFechas
    {
        public ManejoFechas()
        {
        }
        
        public static int obtenerDiasCalendario(DateTime fi, DateTime ff)
        {
            TimeSpan dif;
            dif = ff - fi;
            return dif.Days;
        }
        public static bool esFeriado (DateTime fecha)
        {
            DateTime[] feriados = new DateTime[] 
            {
                new DateTime(2021,1,1),
                new DateTime(2021,2,15),
                new DateTime(2021,2,16),
                new DateTime(2021,3,24),
                new DateTime(2021,4,1),
                new DateTime(2021,4,2),
                new DateTime(2021,5,1),
                new DateTime(2021,5,25),
                new DateTime(2021,6,17),
                new DateTime(2021,6,20),
                new DateTime(2021,7,9),
                new DateTime(2021,8,17),
                new DateTime(2021,10,12),
                new DateTime(2021,11,20),
                new DateTime(2021,12,8),
                new DateTime(2021,12,25)
            };

            return feriados.Contains(fecha.Date);
        }

        public static int obtenerCantFinesDeSemana(DateTime fi, DateTime ff)
        {
            //int diasFindes = 0;
            if (fi.DayOfWeek == DayOfWeek.Saturday || fi.DayOfWeek == DayOfWeek.Sunday)
            {
                
            }
            return ((ff.DayOfYear - fi.DayOfYear) / 7)*2 ;
        }
    }
}
