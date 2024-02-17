using System;

class Program
{
    static void Main()
    {
        string[,] matrizHospital = new string[6, 3];
        string nome, rg, nasc;


        for (int i = 0; i < 6; i++)
        {
            Console.Write("Digite o nome do paciente número " + (i + 1) + ": ");
            nome = Console.ReadLine();

            Console.Write("Digite o RG de " + nome + ": ");
            rg = Console.ReadLine();

            Console.Write("Digite a data de nascimento de " + nome + ": ");
            nasc = Console.ReadLine();

            matrizHospital[i, 0] = nome;
            matrizHospital[i, 1] = rg;
            matrizHospital[i, 2] = nasc;

            Console.Write("\n");
        }

        Console.WriteLine("\nNome do Paciente:\tRG:\t\tData de Nascimento:");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(matrizHospital[i, 0] + "\t\t\t" + matrizHospital[i, 1] + "\t\t\t" + matrizHospital[i, 2]);
        }
    }
}
