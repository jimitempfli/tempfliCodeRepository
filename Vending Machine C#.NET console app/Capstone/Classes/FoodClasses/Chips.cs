using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;

namespace Capstone.Food
{
    public class Chips: Food
    {
        public Chips(string name, decimal price) : base(name, price)
        {

        }
        public override string Consume()
        {
            return "Crunch Crunch, Yum!";
        }
    }
}
