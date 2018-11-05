//Faça um programa que receba a temperatura em Celsius, calcule e mostre essa temperatura em Fahrenheit F =( C * 1.8) + 32

using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;

            Console.WriteLine("Digite a temperatura em Celsius: ");
            C = double.Parse(Console.ReadLine());

            F = (C * 1.8) + 32;

            Console.WriteLine("A temperatura digitada em Fahrenheit é : " + F + "F");

            Console.ReadLine();
        }
    }
}
