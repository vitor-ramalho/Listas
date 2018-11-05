/*/Construa um programa para determinar se o indivíduo está com um peso favorável. Essa
situação é determinada através do IMC (Índice de Massa Corpórea), que é definida como
sendo a relação entre o peso (PESO – em kg) e o quadrado da Altura (ALTURA – em m)
do indivíduo. Ou seja, IMC= PESO/ALTURA 2 e, a situação do peso é determinada pela
tabela abaixo:/*/

using System;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, imc;

            Console.WriteLine("Qual é o seu peso ?");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a sua altura ?");
            altura = double.Parse(Console.ReadLine());
            

            imc = peso / Math.Pow(altura, 2.0);

            Console.WriteLine("O seu IMC é " + imc.ToString("F2"));

            if (imc < 20)
            {
                Console.WriteLine("Abaixo do Peso!");
            }
            else if (imc >= 20 && imc <= 25)
            {
                Console.WriteLine("Peso Normal");
            }
            else if (imc >= 25 && imc <= 30)
            {
                Console.WriteLine("Sobre Peso");
            }
            else if (imc >= 30 && imc <= 40)
            {
                Console.WriteLine("Obeso");
            }
            else if (imc > 40) {
                Console.WriteLine("Obeso Mórbito");
            }

            Console.ReadLine();
        }
    }
}
