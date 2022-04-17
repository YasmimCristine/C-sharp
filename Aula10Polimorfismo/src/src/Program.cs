using Aula10V.src;
using System;
using System.Collections.Generic;

namespace Aula10V
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bicharada");

            List<Animais> Animais = new List<Animais>(
               new Animais[]{
                    new Sapo("Sapo Cláudio", "Verde", "Anfíbio"),
                    new Sapo("Sapo Gilmar", "Marrom", "Anfíbio"),
                    new Pantera ("Pantera Madalena", "Preto", "Felino"),
                    new Elefante ("Elefante Renato", "Cinza", "Mamífero"),
                    new Elefante ("Elefante Clayton", "Cinza", "Mamífero")
               }
            );
            foreach (Animais animal in Animais)
            {
                if (animal.Classificacao == "Anfíbio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comer("Mosca");
                }
                else if (animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comer("Carne");
                }
                else if (animal.Classificacao == "Mamífero")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}");
                    animal.Comer("Melancia");
                }
            }
        }
    }
}
