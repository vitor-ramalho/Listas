using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];
            int[] vetor = new int[4];

            for(int i = 0; i < 4; i++)
            {
                int numMaior = -9999;
                for ( int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Digite um numero: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    if(matriz[i,j] > numMaior)
                    {
                        numMaior = matriz[i, j];
                    }
                }
                vetor[i] = numMaior;
            }
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine(matriz[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Vetor novo com o maior elemento de cada linha: ");

            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine((vetor[i]) + " ");
            }

            Console.ReadKey();
        }
    }
}
