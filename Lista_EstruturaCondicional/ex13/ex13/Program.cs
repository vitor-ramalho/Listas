using System;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoAp, dias, valor = 0, total;

            Console.WriteLine("Digite o tipo de apartamento: (1 para simples 2 para duplo)");
            tipoAp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantos dias de hospedagem ?");
            dias = Convert.ToInt32(Console.ReadLine());

            if (tipoAp == 1)
            {
                if (dias < 10)
                {
                    valor = 100;
                }
                else if (dias == 10 && dias <= 15)
                {
                    valor = 90;
                }
                else
                {
                    valor = 80;
                }
            }
            else if (tipoAp == 2)
            {
                if (dias < 10)
                {
                    valor = 140;
                }
                else if (dias == 10 && dias <= 15)
                {
                    valor = 120;
                }
                else
                {
                    valor = 100;
                }
            }

            total = dias * valor;

            Console.WriteLine("O total a ser pago é " + total + "R$");

            Console.ReadLine();
        }
    }
}
