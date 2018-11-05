//EXERCÍCIO 1 >>> TABUADA.

using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            //variável
            int x;
            
            Console.WriteLine("Digite um número: ");
            //Conversão caractere digitado para int32
            x = int.Parse(Console.ReadLine());

            //Saída de dados e operação da tabuada
            Console.WriteLine(x + " * 1 = " + x * 1);
            Console.WriteLine(x + " * 2 = " + x * 2);
            Console.WriteLine(x + " * 3 = " + x * 3);
            Console.WriteLine(x + " * 4 = " + x * 4);
            Console.WriteLine(x + " * 5 = " + x * 5);
            Console.WriteLine(x + " * 6 = " + x * 6);
            Console.WriteLine(x + " * 7 = " + x * 7);
            Console.WriteLine(x + " * 8 = " + x * 8);
            Console.WriteLine(x + " * 9 = " + x * 9);
            Console.WriteLine(x + " * 10 = " + x * 10);

            Console.WriteLine("Pressione uma tecla para fechar");

            Console.ReadLine();
            
        }
    }
}
