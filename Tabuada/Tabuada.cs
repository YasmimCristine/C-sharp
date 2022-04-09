using System;

namespace ProjetoVSC1
{
    class Program
    {
        static void Main(string[] args)
        {
           int f, c, n;

            Console.WriteLine("Digite o numero da tabuada que deseja saber \n" );
           
            n = Int32.Parse(Console.ReadLine());


    
             for (c =0; c <= 10; ++c)
            {
                f = n * c;
                Console.WriteLine ($" {n} x {c}  = {n*c}\n");

            }

            Console.WriteLine("Muito obrigado por usar nosso cálculo de tabuada!");
            Console.ReadKey();
        }
    }
}
