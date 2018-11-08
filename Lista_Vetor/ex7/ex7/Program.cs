using System;


namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int[] vet2 = new int[10];
            int[] multiplicacao = new int[10];
            int[] divisao = new int[10];

            for(int i= 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i< 10; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vet2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < 10; i++)
            {
                multiplicacao[i] = vet[i] * vet2[i];
                divisao[i] = vet[i] / vet2[i];
            }
            Console.WriteLine("Vetor 1: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vet[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Vetor 2: ");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(vet2[i] + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("Vetor com as multiplicações: ");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(multiplicacao[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Vetor com as divisões: ");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(divisao[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
