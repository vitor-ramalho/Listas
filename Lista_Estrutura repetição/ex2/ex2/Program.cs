using System;


namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int matricula, nota1, nota2, nota3, media;

            Console.WriteLine("Digite sua matricula: ");
            matricula = Convert.ToInt32(Console.ReadLine());

            if (matricula >= 0)
            {
                while (matricula >= 0)
                {
                    
                    Console.WriteLine("Digite a primeira nota: ");
                    nota1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite a segunda nota: ");
                    nota2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite a terceira nota: ");
                    nota3 = Convert.ToInt32(Console.ReadLine());

                    media = (nota1 + nota2 + nota3) / 3;
                    
                    if (media >= 70)
                    {
                        Console.WriteLine("Aprovado!");
                    }
                    else if (media >= 60 && media < 70)
                    {
                        Console.WriteLine("Exame!");
                    }
                    else if (media <= 60)
                    {
                        Console.WriteLine("Reprovado!");
                    }

                    Console.WriteLine("Digite sua matricula: ");
                    matricula = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Fim");
            }

            Console.ReadKey();
        }
    }
}
