using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;

namespace Capstone.Food
{
    public class Drink : Food
    {
        public Drink(string name, decimal price) : base(name, price)
        {

        }
        //properties
        public override string Consume()
        {
            return "Glug Glug, Yum!";
        }
    }
}
