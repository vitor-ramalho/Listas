using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, nota5, media;
            string aluno;

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Digite o seu nome: ");
                aluno = Console.ReadLine();

                Console.WriteLine("Digite sua primeira nota: ");
                nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite sua segunda nota: ");
                nota2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite sua terceira nota: ");
                nota3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite sua quarta nota: ");
                nota4 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite sua quinta nota: ");
                nota5 = Convert.ToDouble(Console.ReadLine());

                media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

                Console.WriteLine(aluno + "A sua média é: " + media);
            }

            Console.ReadLine();
                
        }
    }
}
