class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o " + (i + 1) + "º número: ");
                vetor[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("--------------------------------------------");

            }

            Console.WriteLine("--------------------------------------------");

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] < 0)
                {
                    Console.WriteLine("O número " + vetor[i] + " é negativo\n");
                }
                else
                {
                    Console.WriteLine("O número " + vetor[i] + " é positivo\n");
                }
            }

        }
    }
}
