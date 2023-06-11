

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoReceitas
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public TimeSpan PreparationTime { get; set; }
        public string Instructions { get; set; }

        public Recipe(string name, List<Ingredient> ingredients, TimeSpan preparationTime, string instructions)
        {
            Name = name;
            Ingredients = ingredients;
            PreparationTime = preparationTime;
            Instructions = instructions;
        }

    }

    public class Ingredient
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredient(string name, decimal quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
    }
}
