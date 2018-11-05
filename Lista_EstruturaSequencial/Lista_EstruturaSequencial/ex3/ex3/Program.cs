//Crie um programa que mostre a área de um losango AREA = (DIAGONAL MAIOR * DIAGONAL MENOR) / 2

using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis
            double area, dMaior, dMenor;

            //entrada de dados
            Console.WriteLine("Qual é a diagonal maior do losango ? ");
            dMaior = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a diagonal menor do losango ? ");
            dMenor = double.Parse(Console.ReadLine());

            //Operação
            area = (dMaior * dMenor) / 2;

            //saída de dados
            Console.WriteLine("A área do losango é : " + area);

            Console.ReadLine();

        }
    }
}
