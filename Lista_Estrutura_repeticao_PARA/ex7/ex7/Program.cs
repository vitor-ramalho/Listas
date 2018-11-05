using System;


namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int voto, p = 0;
            int votoHaddad = 0, votoBolsonaro = 0;
            int votosNulo = 0, votosBranco = 0;

            for ( int i = 0; i < 100; i++)
            {
                Console.WriteLine("Vote : (13 para Haddad, 17 para Bolsonaro)");
                voto = Convert.ToInt32(Console.ReadLine());

                if (voto == 13)
                {
                    votoHaddad++;
                    p++;
                }
                else if (voto == 17)
                {
                    votoBolsonaro++;
                    p++;
                }
                else if(voto == votosBranco)
                {
                    votosBranco++;
                    p++;
                }
                else if(voto == votosNulo)
                {
                    votosNulo++;
                    p++;
                }

                Console.WriteLine("O numero de votos para Haddad é: " + votoHaddad);
                Console.WriteLine("O numero de votos para Bonoro é: " + votoBolsonaro);
                Console.WriteLine("O numero de votos em branco é: " + votosBranco);
                Console.WriteLine("O numero de votos nulos é: " + votosNulo);
                
            }

            if(votoBolsonaro > votoHaddad)
            {
                Console.WriteLine("Bolsonaro Ganhou");
            }
            else if(votoHaddad > votoBolsonaro)
            {
                Console.WriteLine("Haddad Ganhou");
            }

            Console.WriteLine("A porcentagem de votos para Haddad é: " + (votoHaddad / p));
            Console.WriteLine("A procentagem de votos para Bonoro é: " + (votoBolsonaro / p));
            Console.WriteLine("A porcentagem de votos brancos é: " + (votosBranco / p));
            Console.WriteLine("A porcentagem de votos nulos é: " + (votosNulo / p));

            Console.ReadLine();
        }
    }
}
