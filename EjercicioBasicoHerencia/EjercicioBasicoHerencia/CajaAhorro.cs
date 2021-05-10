using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioBasicoHerencia
{
    class CajaAhorro : Cuenta
    {
        double interesesCA;

        public CajaAhorro(int dni) : base(dni) { }

        public bool extraccion(double monto)
        {
            if(this.Saldo - monto < 0)
            {
                Console.WriteLine("No posee el saldo suficiente para esta extracción");
                return false;
            }
            this.Saldo -= monto;
            return true;
        }

    }
}
