using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] nome = new string[5];
        double[] avg = new double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite o nome do " + i + "º aluno: ");
            nome[i] = Console.ReadLine();
            Console.WriteLine("Digite a nota do " + i + "º aluno: ");
            avg[i] = double.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 5; i++)
        {
            if (avg[i] >= 6)
            {
                Console.WriteLine(nome[i] + " está aprovado!");
            }
            else
            {
                Console.WriteLine(nome[i] + " está reprovado!");
            }
        }
    }
}
