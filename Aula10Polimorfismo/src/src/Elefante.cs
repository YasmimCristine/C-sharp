using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula10V.src
{
    public class Elefante : Animais
    {
        public Elefante() { }

        public Elefante(string nome, string cor, string classificacao) : base(nome, cor, classificacao) { }

        public override void Comer(string comida)
        {
            Console.WriteLine($"{Nome} está comendo: {comida}");
        }
    }
}