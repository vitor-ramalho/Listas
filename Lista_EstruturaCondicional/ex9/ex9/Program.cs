/*/Escreva um algoritmo que leia o código de um determinado produto e
mostre sua classificação:/*/


using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variáveis
            int x;
            //entrada de dados
            Console.WriteLine("Informe o código do produto de 1 a 15");
            x = int.Parse(Console.ReadLine());

            //Lógica de estrutura condicional e saída de dados;
            if (x == 1)
            {
                Console.WriteLine("Alimento não-perecível");
            }
            else if (x <= 4 && x >= 2)
            {
                Console.WriteLine("Alimento perecível");
            }
            else if (x == 5 || x == 6)
            {
                Console.WriteLine("Vestuário");
            }
            else if (x == 7)
            {
                Console.WriteLine(" Higiene Pessoal");
            }
            else if (x >= 8 && x <= 15)
            {
                Console.WriteLine("Limpeza e utensilios domesticos");
            }
            else {
                Console.WriteLine("Inválido");
            }

            Console.ReadLine();
        }
    }
}
