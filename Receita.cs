

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoReceitas
{
    public class Receita
    {
        public string Nome { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }
        public TimeSpan TempoPreparacao { get; set; }
        public string Instrucoes { get; set; }

        public Receita(string name, List<Ingrediente> ingredients, TimeSpan preparationTime, string instructions)
        {
            Nome = name;
            Ingredientes = ingredients;
            TempoPreparacao = preparationTime;
            Instrucoes = instructions;
        }

    }

    public class Ingrediente
    {
        public string Nome { get; set; }
        public decimal Quantidade { get; set; }
        public string Unidade { get; set; }

        public Ingrediente(string name, decimal quantity, string unit)
        {
            Nome = name;
            Quantidade = quantity;
            Unidade = unit;
        }
    }
}
