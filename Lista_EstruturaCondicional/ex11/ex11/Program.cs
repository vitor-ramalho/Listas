using System;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int diarias;
            double txservico, total;

            Console.WriteLine("Quantos dias ?");
            diarias = Convert.ToInt32(Console.ReadLine());

            if (diarias < 15)
            {
                txservico = 1.50;
            }
            else if (diarias == 15)
            {
                txservico = 1;
            }
            else
            {
                txservico = 0.50;
            }

            total = diarias * 50 + txservico * diarias;

            Console.WriteLine("O total a ser pago é:" + total);


            Console.ReadLine();

        }
    }
}
