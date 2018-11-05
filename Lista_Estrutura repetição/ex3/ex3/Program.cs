using System;


namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, homens, mulheres, p;
            char sexo;
            double peso;

            p = 10;
            homens = 0;
            mulheres = 0;

            while (p <= 10 && p >=0 )
            {
                Console.WriteLine("Digite seu sexo (M ou F): ");
                sexo = Convert.ToChar(Console.ReadLine());

                if (sexo == 'M')
                {
                    Console.WriteLine("Informe sua idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Informe seu peso: ");
                    peso = Convert.ToInt32(Console.ReadLine());

                    if ((idade >=20 && idade <=30) && (peso > 60))
                    {
                        homens++;
                        p--;
                    }
                    else
                    {
                        homens = homens + 0;
                        p--;
                    }
                }
                else if (sexo == 'F')
                {
                    Console.WriteLine("Informe sua idade: ");
                    idade = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Indorme seu peso: ");
                    peso = Convert.ToInt32(Console.ReadLine());

                    if (idade > 40 && peso < 70)
                    {
                        mulheres++;
                        p--;
                    }
                    else
                    {
                        mulheres = mulheres + 0;
                        p--;
                    }
                }
                else
                {
                    Console.WriteLine("Informe o sexo corretamente");
                }

            }


            Console.WriteLine("A quantidade de homens é: " + homens);
            Console.WriteLine("A quantidade de mulheres é: " + mulheres);

            Console.ReadKey();
        }
    }
}
