using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioBasicoHerencia
{
    class CuentaCorriente : Cuenta
    {
        double descubierto;
        double interesesDescubierto;

        public CuentaCorriente(int dni) : base(dni) { }
    }
}
