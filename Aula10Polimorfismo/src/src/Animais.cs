using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10V.src
{
    public class Animais
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Classificacao { get; set; }

        public Animais() { }

        public Animais(string nome, string cor, string classificacao)
        {
            Nome = nome;
            Cor = cor;
            Classificacao = classificacao;
        }

        public virtual void Comer(string comida)
        {
            Console.WriteLine($"{Nome} está comendo: {comida}");
        }
    }
}