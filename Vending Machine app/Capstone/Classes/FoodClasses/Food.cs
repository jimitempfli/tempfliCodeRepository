using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;

namespace Capstone.Food
{
    public abstract class Food
    {
        public const string Candy = "Candy";
        public const string Gum = "Gum";
        public const string Drink = "Drink";
        public const string Chip = "Chip";

        // properties
        public string Name { get; }
        public decimal Price { get; }

        public Food(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public abstract string Consume();
    }
}
