using System;


namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int[] vet2 = new int[10];
            int numeros = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Informe 5 números: ");
                vet2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(vet[i] == vet2[j])
                    {
                        numeros++;
                    }
                }
            }

            Console.WriteLine("Os números digitados foram encontrados {0} vezes no vetor.", numeros);

            Console.ReadKey();
        }
    }
}
