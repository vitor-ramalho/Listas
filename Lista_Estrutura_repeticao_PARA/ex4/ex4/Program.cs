using System;


namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, idadeMaior =0, idadeMenor = 1000;

            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Digite a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade > idadeMaior && idade < idadeMenor)
                {
                    idadeMaior = idade;
                    idadeMenor = idade;
                }
                else if (idade < idadeMaior && idade < idadeMenor)
                {
                    idadeMenor = idade;
                }
                else if (idade > idadeMaior && idade > idadeMenor)
                {
                    idadeMaior = idade;
                }
                else if (idade > idadeMaior && idade > idadeMenor)
                {
                    idadeMaior = idade;
                }
                else
                { 
                
                }

                Console.WriteLine("A maior idade é " + idadeMaior + " anos.");
                Console.WriteLine("A menor idade é " + idadeMenor + " anos.");
            }

            Console.ReadKey();
        }
    }
}
