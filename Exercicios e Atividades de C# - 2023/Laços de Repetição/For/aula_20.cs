using System;

namespace aula_26_for1a50
{
    class Program
    {
        static void Main(string[] args)
        {

                int soma = 0;

                for (int i = 1; i <= 50; i++)
                {

                    if (i % 3 == 0)
                    {
                        soma += i;
                    }

                }
                Console.WriteLine("A soma dos múltiplos de três de 1 a 50 é: " + soma);
            }
    }
}

