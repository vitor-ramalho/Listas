using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] vet = new int[4, 4];
            for( int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vet[i, 0] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(vet[i, 0]);
            }

            Console.ReadKey();
        }
    }
}
