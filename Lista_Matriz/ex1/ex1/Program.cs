using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite um numero");
                matriz[0, i] = Convert.ToInt32(Console.ReadLine());
            }
            for ( int i = 0; i < 4; i++)
            {
                Console.WriteLine(matriz[0, i]);
            }
            Console.ReadKey();
        }
    }
}
