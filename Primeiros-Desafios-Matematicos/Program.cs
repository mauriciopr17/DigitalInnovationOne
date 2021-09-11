using System;

namespace Primeiros_Desafios_Matematicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Digite o primeiro número para soma: ");

            int A = Convert.ToInt32( Console.ReadLine() );
            
            Console.Write("Digite o segundo número para soma: ");
            int B = Convert.ToInt32( Console.ReadLine() );

            int soma = A + B;

            Console.WriteLine("Soma = {0} ", soma);

            Console.WriteLine("-------------- DDD ------------");
            Console.Write("Digite o DDD: ");

            int ddd = Convert.ToInt32(Console.ReadLine());

            switch (ddd)
            {
                case 61:
                 Console.Write("Brasília");
                 break;
                
                case 71:
                 Console.Write("Salvador");
                 break; 
                
                case 11:
                 Console.Write("São Paulo");
                 break;
                
                case 21:
                 Console.Write("Rio de Janeiro");
                 break; 
                
                case 32:
                 Console.Write("Juiz de Fora");
                 break;

                case 19:
                 Console.Write("Campinas");
                 break; 

                case 27:
                 Console.Write("Vitória");
                 break;

                case 31:
                 Console.Write("Belo Horizonte");
                 break;

                default:
                 Console.Write("DDD não encontrado");
                 break;
            }




        }
    }
}
