//Dados três valores X,Y,Z, verificar se eles podem ser os comprimentos dos lados de um
///triângulo.Se eles não formarem um triângulo escrever uma mensagem.Considerar que o
//comprimento de cada lado de um triângulo é menor que a soma dos outros dois lados.

using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            //variáveis
            double x, y, z;

            //entrada de dados
            Console.WriteLine("Informe o primeiro número: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro número");
            z = double.Parse(Console.ReadLine());

            //Condição para medidas serem possíveis de fazer um triângulo
            if (x < y + z && y < z + x && z < x + y)
            {
                Console.WriteLine("Você pode fazer o triângulo!");
            }
            else
            {
                Console.WriteLine("Incapaz de formar Triângulo");
            }

            Console.ReadLine();
        }
    }
}
