using System;
/*
 * Ejercicio Básico Herencia

    Cree una jerarquía de clases utilizando herencia
    Considere una cuenta bancaria, la que puede ser de dos tipos: C.A. o C.C.
    Una C.C. puede tener un tope de descubierto, y en tal caso posee intereses negativos
    Simule 100 transacciones (depósitos/extracciones) ingresando montos aleatorios que pueden ir de $10 a $10000
*/
namespace EjercicioBasicoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de DNI o CUIT: (solo números, sin puntos o guiones)");
            CajaAhorro c1 = new CajaAhorro(int.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese el monto a depositar: ");
            c1.depositar(int.Parse(Console.ReadLine()));
            Console.WriteLine("Ingrese el monto a extraer: ");
            c1.extraccion(int.Parse(Console.ReadLine()));
            Console.WriteLine(c1.Saldo);
        }
    }
}
