using System;


namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[10];
            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero:");
                vetor[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Elementos pares: ");

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
            Console.WriteLine("");

            Console.WriteLine("Elementos ímpares: ");

            for (int i = 0; i < 10; i++)
            {
                if(vetor[i] % 2 != 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
