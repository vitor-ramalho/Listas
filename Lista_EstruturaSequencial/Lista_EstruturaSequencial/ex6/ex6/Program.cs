//Faça um programa que receba o valor do salário mínimo e o valor do salário de um
//funcionário, calcule e mostre a quantidade de salários mínimos que ganha esse funcionário.


using System;


namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double salariomin, salariofuncionario, qtsalario;

            Console.WriteLine("Qual é o valor do salário mínimo ?");
            salariomin = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o valor do seu salário? ");
            salariofuncionario = double.Parse(Console.ReadLine());

            qtsalario = salariofuncionario / salariomin;

            Console.WriteLine("Você recebe " + qtsalario.ToString("F2") + " salário(s) minimo(s).");

            Console.ReadLine();

        }
    }
}
