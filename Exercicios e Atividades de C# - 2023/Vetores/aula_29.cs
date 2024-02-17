using System;

class Program
{
    public static void Main(string[] args)
    {
        string[] paciente = new string[5];
        string[] medico = new string[5];
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite o nome do " + i + "º paciente: ");
            paciente[i] = Console.ReadLine();

            Console.WriteLine("Digite o nome do " + i + "º médico: ");
            medico[i] = Console.ReadLine();
        }
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("O nome do " + i + "º paciente é " + paciente[i]);

            Console.WriteLine("O nome do " + i + "º médico é " + medico[i]);
        }
    }
}
