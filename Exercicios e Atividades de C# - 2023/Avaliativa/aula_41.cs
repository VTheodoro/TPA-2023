using System;

namespace verificar_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idade = new int[10];
            int[] idade_digitada = new int[10];

            string[] nome = new string[10];

            int repetidas = 0;

            for (var line = 0; line < 10; line++)
            {
                Console.WriteLine("Digite o nome da "+(line+1)+"º pesssoa: ");
                nome[line] = Console.ReadLine();

                Console.WriteLine("Digite a idade de "+nome[line]+":");
                idade[line] = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                if ((idade[line] == idade_digitada[0]) || (idade[line] == idade_digitada[1]) || (idade[line] == idade_digitada[2]) || (idade[line] == idade_digitada[3]) || (idade[line] == idade_digitada[4]) || (idade[line] == idade_digitada[5]) || idade[line] == idade_digitada[6] || (idade[line] == idade_digitada[7]) || (idade[line] == idade_digitada[8]) || (idade[line] == idade_digitada[9]))
                {
                    Console.WriteLine("Uma idade repetida foi registrada!\n");
                    repetidas++;
                }
                idade_digitada[line] = idade[line];

            }
            Console.WriteLine("\nNome:\t\tIdade:");
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine(nome[i]+"\t\t"+idade[i]);
            }
            Console.WriteLine("O total de idades repetidas foi de "+repetidas);
        }
    }
}
