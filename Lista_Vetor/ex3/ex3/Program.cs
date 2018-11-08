using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];

            int menor = 99999;
            int maior = 0;
            int indexMaior = 0;
            int indexMenor = 0;
            int i;
            
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            
                if(vet[i] > maior && vet[i] < menor)
                {
                    maior = vet[i];
                    menor = vet[i];

                    indexMaior = i;
                    indexMenor = i;
                }
                else if (vet[i] > maior)
                {
                    maior = vet[i];
                    indexMaior = i;
                }
                else if(vet[i] < menor)
                {
                    menor = vet[i];
                    indexMenor = i;
                }
            }

            Console.WriteLine("O maior número do vetor é {0}.", maior);
            Console.WriteLine("O index do maior numero é {0}.", indexMaior);
            Console.WriteLine("O menor número do vetor é {0}.", menor);
            Console.WriteLine("O index do menor número é {0}.", indexMenor);

            Console.ReadKey();

        }
    }
}
