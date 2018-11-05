using System;


namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            int idade, quantHomens = 0, quantMulheres = 0;

            for(int i= 0; i < 20; i++)
            {
                Console.WriteLine("Digite a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o seu sexo: (M ou F)");
                sexo = Console.ReadLine();
                sexo = sexo.ToUpper();

                if (sexo == "F")
                {
                    if (idade >= 20 && idade <= 40)
                    {
                        quantMulheres++;
                    }
                }
                else
                {
                    quantHomens++;
                }

                Console.WriteLine("A quantidade de mulheres com idade entre 20 e 40 anos é: " + quantMulheres);
            }

            

            Console.ReadKey();
        }
    }
}
