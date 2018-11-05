using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, pesoMaior = 0;
            double media, peso;

            //declaração do vetor de 30 posições
            int[] idade;
            idade = new int[30];
            
            //entrada de dados das 30 pessoas
            for(int i = 0; i < 30; i++)
            {
                Console.WriteLine("Digite a sua idade: ");
                idade[i] = int.Parse(Console.ReadLine());
               
                Console.WriteLine("Digite o seu peso: ");
                peso = Convert.ToInt32(Console.ReadLine());

                //armazenamento da quantidade de pessoas com mais de 90kg
                if (peso > 90)
                {
                    pesoMaior++;
                }
                
            }
            //Soma dos valores do vetor
            for (int i = 0; i < 30; i++)
            {
                soma += idade[i];
            }

            media = soma / 30;

            Console.WriteLine("A quantidade de pessoas com 90 kilos é: " + pesoMaior);
            Console.WriteLine("A media entre as idade é: " + media);

            Console.ReadLine();
            
        }
    }
}
