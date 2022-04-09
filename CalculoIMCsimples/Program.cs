using System;

namespace CalculoIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float altura;
            float peso;
            float imc;
            int idade;
            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua altura: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe seu peso: ");
            peso = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);
            Console.WriteLine("Seu imc é: " + imc);

           

        }
    }
}
