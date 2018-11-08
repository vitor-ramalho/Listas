using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int valor;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite um numero: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for ( int i = 0; i < 3; i++)
            {
                for ( int j = 0; j < 3; j++)
                {
                    Console.WriteLine(matriz[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Digite um valor:");
            valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Os valores da matriz multiplicados pelo valor digitado são: ");
            for (int i = 0; i < 3; i++)
            {
                for( int j = 0; j < 3; j++)
                {
                    matriz[i, j] = matriz[i, j] * valor;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for ( int j = 0; j < 3; j++)
                {
                    Console.WriteLine(matriz[i, j] + " ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
