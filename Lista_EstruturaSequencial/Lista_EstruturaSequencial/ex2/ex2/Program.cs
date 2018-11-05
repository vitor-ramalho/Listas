//Crie um programa em que receba de entrada um número negativo e converta ele para positivo

using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Digite um número negativo: ");

            x = int.Parse(Console.ReadLine());

            x = -(x);

            Console.WriteLine("Número : " + x);

            Console.ReadLine();


        }
    }
}
