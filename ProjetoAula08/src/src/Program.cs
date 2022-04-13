using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Macaco");
           Macaco cesar = new Macaco("Cesar", "Preto", "Um Metro", "Verde" );

           Console.WriteLine($"O nome do macaco é: {cesar.nome}, A sua cor é: {cesar.cor}, O seu tamanho é: {cesar.tamanho}, A cor dos seus olhos é: {cesar.corOlho}");

           cesar.fala();
           cesar.poder();
           cesar.som();
        }
    }
}
