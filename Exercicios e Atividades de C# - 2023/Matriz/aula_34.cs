using System;

class Program
{
    static void Main()
    {
        string[,] matrizSalarios = new string[4, 2];
        string codigo, salario;


        for (int i = 0; i < 4; i++)
        {
            Console.Write("Digite o código do funcionário número " + (i + 1) + ": ");
            codigo = Console.ReadLine();

            Console.Write("Digite o salário do funcionário " + codigo + ": ");
            salario = Console.ReadLine();

            matrizSalarios[i, 0] = codigo;
            matrizSalarios[i, 1] = salario;

            Console.Write("\n");
        }

        Console.WriteLine("\nCódigo do Funcionáro:\tSalário:");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(matrizSalarios[i, 0] + "\t\t\t" + "R$" + matrizSalarios[i, 1]);
        }
    }
}
