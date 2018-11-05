//Crie um programa que receba a data de nascimento de uma pessoa e calcule quantos dias,
//aproximados, ela já viveu até hoje.
using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            double idade;

            Console.WriteLine("Qual é a sua idade? ");
            idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Você já viveu " + (idade * 365) + " dias!");

            Console.ReadLine();
        }
    }
}
