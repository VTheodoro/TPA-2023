using System;

namespace aula07_6pessoas
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nome = new string[6];
            int[] idade = new int[6];
            int[] altura = new int[6];
            double[] peso = new double[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Digite o nome da " + (i + 1) + "º pessoa: ");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Digite a idade de " + nome[i] + ": ");
                idade[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a altura (em CM) da " + nome[i] + ": ");
                altura[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o peso da " + nome[i] + ": ");
                peso[i] = double.Parse(Console.ReadLine());

                Console.WriteLine("--------------------------------------------");

            }

            Console.WriteLine("--------------------------------------------");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(nome[i] + ": ");
                Console.WriteLine("Idade: " + idade[i]+" Anos");
                Console.WriteLine("Altura: " + altura[i]+" CM");
                if (idade[i] >= 20)
                {
                    Console.WriteLine("Peso: " + peso[i]+" Kg");
                    Console.WriteLine("");
                    Console.WriteLine(nome[i] + " Tem MAIS que 20 anos!");
                }
                else
                {
                    Console.WriteLine(nome[i] + " Tem MENOS que 20 anos!");
                }
                Console.WriteLine("--------------------------------------------\n");

            }


        }
    }
}
