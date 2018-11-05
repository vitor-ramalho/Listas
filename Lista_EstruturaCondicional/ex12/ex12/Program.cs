using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            int sexo, idade, valor = 0;

            Console.WriteLine("Digite o seu sexo: (0 para homem e 1 para mulher ");
            sexo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a sua idade");
            idade = Convert.ToInt32(Console.ReadLine());

            if (sexo == 0)
            {
                if (idade <= 15)
                {
                    valor = 60;
                }
                else if (idade >= 16 && idade <= 18)
                {
                    valor = 75;
                }
                else if (idade >= 19 && idade <= 30)
                {
                    valor = 90;
                }
                else if (idade >= 31 && idade <= 40)
                {
                    valor = 85;
                }
                else
                {
                    valor = 80;
                }

            }
            else if (sexo == 1)
            {
                if (idade <= 18)
                {
                    valor = 60;
                }
                else if (idade >= 19 && idade <= 25)
                {
                    valor = 90;
                }
                else if (idade >= 26 && idade <= 40)
                {
                    valor = 85;
                }
                else
                {
                    valor = 80;
                }
            }
            else
            {
                Console.WriteLine("Tente novamente");
            }

            Console.WriteLine("O valor da mensalidade é " + valor + "R$");

            Console.ReadLine();
        }
    }
}
