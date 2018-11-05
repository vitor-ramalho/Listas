using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            double peso;
            int quantHomens = 0, quantMulheres = 0;


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o seu sexo: (M ou F)");
                sexo = Console.ReadLine();
                sexo = sexo.ToUpper();

                Console.WriteLine("Digite o seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                if (sexo == "M")
                {
                    if ( peso >= 60 && peso <= 80)
                    {
                        quantHomens++;
                    }
                }
                else if(sexo == "F")
                {
                    if(peso >= 50 && peso <= 70)
                    {
                        quantMulheres++;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, digite um peso e um sexo válido e" +
                                          " tente novamente executar o programa");
                    break;
                }
                Console.WriteLine("Homem entre 60 e 80 quilos: " + quantHomens);
                Console.WriteLine("Mulheres entre 50 e 70 quilos: " + quantMulheres);
            }

        }
    }
}
