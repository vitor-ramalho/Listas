using System;


namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[2, 3];
            int maiorNumero = 0;
            int menorNumero = 10000;
            string posicaoMenor = "";
            string posicaoMaior = "";

            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite um numero:");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    if(matriz[i, j] < menorNumero && matriz[i,j] > maiorNumero)
                    {
                        maiorNumero = matriz[i, j];
                        menorNumero = matriz[i, j];
                        posicaoMaior = Convert.ToString("Linha " + i + " Coluna " + j);
                        posicaoMenor = Convert.ToString("Linha " + i + " Coluna " + j);
                    }
                    else if(matriz[i, j] > maiorNumero)
                    {
                        maiorNumero = matriz[i, j];
                        posicaoMaior = Convert.ToString("Linha " + i + " Coluna " + j);
                    }
                    else if ( matriz[i,j] < menorNumero)
                    {
                        menorNumero = matriz[i, j];
                        posicaoMenor = Convert.ToString("Linha " + i + " Coluna " + j);
                    }

                }
            }

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j< 3; j++)
                {
                    Console.WriteLine(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("O maior número da Array é {0}", maiorNumero);
            Console.WriteLine("A posição do maior número é: {0}", posicaoMaior);
            Console.WriteLine("O menor número da Array é {0}", menorNumero);
            Console.WriteLine("A posição do menor número é {0}", posicaoMenor);

            Console.ReadKey();
        }
    }
}
