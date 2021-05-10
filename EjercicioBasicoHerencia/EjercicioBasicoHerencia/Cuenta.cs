using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioBasicoHerencia
{
    class Cuenta
    {
        private int numero = 0;
        public int dni; //por reglas del negocio no puedo tener una cuenta si no esta asociada a un dni-cuit
        private double saldo = 0.0;

        public int Numero { get => numero;}
        public double Saldo { get => saldo; set => saldo = value; }
        public int Dni { get => dni; set => dni = value; }
        
        public Cuenta(int dni)
        {
            numero++;
            this.numero = Numero;
            this.saldo = 0;
            this.dni = dni;
        }

        public Cuenta(double saldo, int dni)
        {
            this.numero++;
            this.numero = Numero;
            this.saldo = saldo;
            this.dni = dni;
        }
        
        public void depositar(double monto)
        {
            Console.WriteLine("El saldo antes del depósito es de: {0}", this.saldo);
            this.saldo += monto;
            Console.WriteLine("El saldo ahora es de: {0}", this.saldo);
        }
    }
}
