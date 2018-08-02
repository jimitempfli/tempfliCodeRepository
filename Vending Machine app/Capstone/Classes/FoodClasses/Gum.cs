using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;

namespace Capstone.Food
{
    public class Gum : Food
    {
        public Gum(string name, decimal price) : base(name, price)
        {

        }
        public override string Consume()
        {
            return "Chew Chew, Yum!";
        }
    }
}
