using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 5];
            int numerosSelec = 0;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Digite um número: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());

                    if(matriz[i, j] >= 15  && matriz[i, j] <= 20)
                    {
                        numerosSelec++;
                    }
                }
            }
            for ( int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine(matriz[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("A quantidade de números entre 15 e 20 dentro da matriz é {0}", numerosSelec);
            Console.ReadKey();
        }
    }
}
