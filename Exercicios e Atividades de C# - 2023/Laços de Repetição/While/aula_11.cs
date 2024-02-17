using System;

namespace CalculoMediaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;

            while (contador <= 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("ALUNO " + contador + "\n");
                Console.ResetColor();
Console.Write("Nome do aluno: ");
                string nomeAluno = Console.ReadLine();

                Console.Write("Nota A: ");
                double notaA = double.Parse(Console.ReadLine());

                Console.Write("Nota B: ");
                double notaB = double.Parse(Console.ReadLine());

                double media = (notaA + notaB) / 2;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n------------------------------------------");
                Console.WriteLine("Aluno: " + nomeAluno);
                Console.WriteLine("Média: " + media);
                Console.WriteLine("------------------------------------------\n");
                Console.ResetColor();

                contador++;
            }
        }
    }
}
