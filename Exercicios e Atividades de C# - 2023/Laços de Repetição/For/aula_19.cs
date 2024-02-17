using System;

namespace aula_29_somMulheres
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPessoas = 4;
            int homens = 0;

            Console.WriteLine("Digite a altura e o sexo (M ou F) de " + totalPessoas + " pessoas:");

            for (int i = 0; i < totalPessoas; i++)
            {
                Console.Write("Altura da pessoa " + (i + 1) + ": ");
                double altura = double.Parse(Console.ReadLine());

                Console.Write("Sexo da pessoa " + (i + 1) + " (M ou F): ");
                char sexo = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (sexo == 'M')
                {
                    homens++;
                }
                else if (sexo == 'F')
                {
                    if (altura > 0)
                    {
                        Console.WriteLine("Altura da mulher: " + altura);
                    }
                    else
                    {
                        Console.WriteLine("Altura inválida para mulher.");
                    }
                }
                else
                {
                    Console.WriteLine("Sexo inválido. Use M ou F.");
                    i--;
                }

                Console.WriteLine("Quantidade de homens: " + homens);
            }
        }
    }
}
