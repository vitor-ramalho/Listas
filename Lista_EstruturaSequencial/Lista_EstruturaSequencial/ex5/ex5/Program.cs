//Faça um programa que receba o peso de uma pessoa, calcule e mostre:
//a.O seu novo peso, se a pessoa engordar 15% sobre o peso digitado
//b.O seu novo peso, se a pessoa emagrecer 20% sobre o peso digitado

using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;

            Console.WriteLine("digite o seu peso!");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Se você engordar 15%, voce terá " + (peso + (peso * 0.20)) + " quilos!");
            Console.WriteLine("Se você emagrecer 20%, voce terá " + (peso - (peso * 0.15)) + " quilos!");
            
            Console.ReadKey();

        }
    }
}
