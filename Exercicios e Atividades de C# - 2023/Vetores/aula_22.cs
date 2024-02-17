class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[300];
            double cont = 0;

            for (int i = 1; i <= 300; i++)
            {
                vetor[i - 1] = i;
            }

            foreach (int numero in vetor)
            {
                if (numero % 3 == 0)
                {
                    Console.WriteLine(numero + " é múltiplo de 3");
                    cont++;
                }
            }

            Console.WriteLine("O total de múltiplos de 3 de 1 a 300 é: " + cont);
        }
    }
}
