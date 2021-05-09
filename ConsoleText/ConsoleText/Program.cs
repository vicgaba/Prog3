using System;

namespace ConsoleText
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "";
            while (texto == "")
            {
                Console.WriteLine("Ingrese un texto: ");
                texto = Console.ReadLine();
            }

            ConsoleKeyInfo cki; 
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1 - Convertir a mayúsculas");
            Console.WriteLine("2 - Convertir a minúsculas");
            Console.WriteLine("3 - Mostrar texto original");
            cki = Console.ReadKey(true);

            if (cki.Key == ConsoleKey.D1 || cki.Key == ConsoleKey.NumPad1) Console.WriteLine(texto.ToUpper());
            if (cki.Key == ConsoleKey.D2 || cki.Key == ConsoleKey.NumPad2) Console.WriteLine(texto.ToLower());
            if (cki.Key == ConsoleKey.D3 || cki.Key == ConsoleKey.NumPad3) Console.WriteLine(texto);
        }
    }
}
