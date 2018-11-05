using System;


namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, notaMaior = 100, notaMenor = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite a primeira nota: ");
                nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a segunda nota: ");
                nota2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a terceira nota: ");
                nota3 = Convert.ToDouble(Console.ReadLine());

                if (nota1 > nota2 && nota2 > nota3)
                {
                    notaMaior = nota1;
                    notaMenor = nota3;
                }
                else if( nota1 > nota3 && nota3 > nota2)
                {
                    notaMaior = nota1;
                    notaMenor = nota2;
                }
                else if (nota2 > nota1 && nota1 > nota3)
                {
                    notaMaior = nota2;
                    notaMenor = nota3;
                }
                else if(nota2 > nota3 && nota3 > nota1)
                {
                    notaMaior = nota2;
                    notaMenor = nota1;
                }
                else if (nota3 > nota1 && nota2 > nota1)
                {
                    notaMaior = nota3;
                    notaMenor = nota1;
                }
                else if(nota3 > nota1 && nota1 > nota2)
                {
                    notaMaior = nota3;
                    notaMenor = nota2;
                }

                Console.WriteLine("A maior nota é: " + notaMaior);
                Console.WriteLine("A menor nota é: " + notaMenor);
            }

            Console.ReadKey();
        }
    }
}
