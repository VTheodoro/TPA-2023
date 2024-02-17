using System;

namespace aula_24_1a300
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 1;
            int fim = 300;
            int contador = 0;

            Console.WriteLine("Números múltiplos de 3 de " + inicio + " a " + fim + ":");

            for (int i = inicio; i <= fim; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    contador++;
                }
            }

            Console.WriteLine("Quantidade de números múltiplos de 3: " + contador);
        }
    }
    }
