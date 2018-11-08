using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];
            int[] positivos = new int[10];
            int[] negativos = new int[10];

            for ( int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
                if(vet[i] < 0)
                {
                    negativos[i] = vet[i];
                }
                else if ( vet[i] >= 0)
                {
                    positivos[i] = vet[i];
                }
            }

            Console.WriteLine("Vetor com todos os numeros: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vet[i] + " ");
            }
            Console.WriteLine(" ");

            Console.WriteLine("Vetor com os números positivos: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(positivos[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Vetor com os numeros negativos: ");
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(negativos[i] + " ");
            }

            Console.ReadKey();

        }
    }
}
