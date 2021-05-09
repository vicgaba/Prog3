using System;

namespace Moda
{
    class Program
    {       
        static void Main(string[] args)
        {
            int max;
            int min;
            int x = Moda(out max, out min, 10, 5, 2, 3, 3, 4, 5, 7,10,5); 

            Console.WriteLine("El mayor ingresado es: {0}, el menor es: {1}",max, min);
            Console.WriteLine("La moda es: {0}", x);
        }

        public static int Moda(out int max, out int min, params int[] valores)
        {

            int pos = 0;
            int rep = 0;
            int aux = 0;
            max = valores[0];
            min = valores[0];

            for (int i = 0; i < valores.Length; i++)
            {
                if (valores[i] > max)
                {
                    max = valores[i];
                }
                if (valores[i] < min)
                {
                    min = valores[i];
                }
                for (int j = 0; j < valores.Length; j++)
                {
                    if (valores[i] == valores[j])
                    {
                        aux++;
                    }
                }
                if (aux > rep)
                {
                    pos = i;
                    rep = aux;
                }
                aux = 0;

            }
            return valores[pos];
        }
    }
}
