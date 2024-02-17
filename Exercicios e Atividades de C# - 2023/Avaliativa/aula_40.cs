using System;

namespace _15num
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] notas = new double[15];
            double media = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Digite a nota da prova do " + (i + 1) + "º aluno: ");
                notas[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 15; i++)
            {
                media = media + notas[i];
            }

            Console.Write("\n\nA média de notas da sala foi de "+media+".");

        }
    }
}
