using System;

class Program
{
    static void Main()
    {
        string[,] matrizAlunos = new string[5, 4];
        string nome;
        string mediaProvas, mediaTrabalhos, matricula;


        for (int i = 0; i < 5; i++)
        {
            Console.Write("Digite o nome do aluno " + (i + 1) + ": ");
            nome = Console.ReadLine();

            Console.Write("Digite o número da matrícula de " + nome + ": ");
            matricula = Console.ReadLine();

            Console.Write("Digite a média das PROVAS de " + nome + ": ");
            mediaProvas = Console.ReadLine();

            Console.Write("Digite a média dos TRABALHOS de " + nome + ": ");
            mediaTrabalhos = Console.ReadLine();
            matrizAlunos[i, 3] = nome;
            matrizAlunos[i, 0] = matricula;
            matrizAlunos[i, 1] = mediaProvas;
            matrizAlunos[i, 2] = mediaTrabalhos;

            Console.Write("\n");
        }

        Console.WriteLine("\nNúmero da Matricula:\tMédia das Provas:\tMédia dos Trabalhos:\tNome:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(matrizAlunos[i, 0] + "\t\t\t" + matrizAlunos[i, 1] + "\t\t\t" + matrizAlunos[i, 2] + "\t\t\t" + matrizAlunos[i, 3]);
        }
    }
}
