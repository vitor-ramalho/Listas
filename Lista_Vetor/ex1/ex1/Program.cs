using System;


namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[10];
            double soma = 0, media = 0;
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero");
                vetor[i] = Convert.ToDouble(Console.ReadLine());
                soma += vetor[i];
            }
            media = soma / i;
            Console.WriteLine("media = " + media);

            Console.WriteLine("numeros acima media");
            for (i = 0; i < 10; i++)
            {
                if (vetor[i] > media)
                    Console.WriteLine(vetor[i]);
            }
            Console.WriteLine("numeros abaixo media");
            for (i = 0; i < 10; i++)
            {
                if (vetor[i] < media)
                    Console.WriteLine(vetor[i]);
            }

            Console.ReadKey();

        }
    }
}

