using System;

namespace Altura
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] altura = new int[4];
            string[] sexo = new string[4];
            int contM = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite a altura da " + (i + 1) + "ª pessoa em Cm:");
                altura[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o sexo da " + (i + 1) + "ª pessoa\n(M para MASCULINO ou F para FEMININO):");
                sexo[i] = Console.ReadLine();
                Console.WriteLine(); 

                if (sexo[i] == "M" || sexo[i] == "m")
                {
                    contM++;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if (altura[i] > 0)
                {
                    Console.WriteLine("A altura da " + (i + 1) + "ª mulher é " + altura[i]);
                }
            }

            Console.WriteLine("\nA quantidade de homens é " + contM);
        }
    }
}
