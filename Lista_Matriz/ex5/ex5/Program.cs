using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int operacao, coluna, linha;
            int soma = 0;

            for(int i = 0; i < 3; i++)
            {
                for( int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite um número: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine(matriz[i, j] + " ");
                }

                Console.WriteLine("");
            }
            Console.WriteLine("Digite 1 para fazer operação com coluna e 2 para fazer uma operação com linha");
            operacao = Convert.ToInt32(Console.ReadLine());

            if (operacao == 2)
            {
                Console.WriteLine("Informe o numero da linha(0, 1 ou 2): ");
                linha = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine(matriz[linha, k]);
                    Console.WriteLine("");
                    soma += (matriz[linha, k]);
                }
                Console.WriteLine("");
                Console.WriteLine("A soma dos numeros da linha escolhida é {0}", soma);

            }
            else if (operacao == 1)
            {
                Console.WriteLine("Informe o numero da coluna (0, 1 ou 2): ");
                coluna = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                for(int i = 0; i < 3; i++)
                {
                    Console.WriteLine(matriz[i, coluna]);
                }
                Console.WriteLine("");
                Console.WriteLine("A soma dos numeros da linha escolhida é {0}", soma);
            }

            Console.ReadKey();
        }
    }
}
