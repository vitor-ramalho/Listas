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
            int[] vet = new int[10];
            bool procurarNumero = true;
            bool numeroEncontrado;
            int numero, opcao;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número: ");
                vet[i] = Convert.ToInt32(Console.ReadLine());
            }
            while(procurarNumero == true)
            {
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());
                numeroEncontrado = false;

                for(int i = 0; i < 10; i++)
                {
                    if (vet[i] == numero)
                    {
                        numeroEncontrado = true;
                    }
                }

                if(numeroEncontrado == true)
                {
                    Console.WriteLine("Número encontrado");
                }
                else if (numeroEncontrado == false)
                {
                    Console.WriteLine("Número não encontrado");
                }
                Console.WriteLine("DEseja encontrar outro numero? (1 para sim 2 para não)");
                opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == 1)
                {
                    procurarNumero = true;
                }
                else
                {
                    procurarNumero = false;
                }
            }
            Console.ReadKey();
        }
    }
}
