using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;

namespace Capstone.Food
{
    public class InventoryItem
    {
        //properties
        public Food FoodItem { get; }
        public int Quantity { get; set; } = 5;

        public InventoryItem(Food foodItem)
        {
            FoodItem = foodItem;
        }
        public override string ToString()
        {
            return FoodItem.Name + "(" + Quantity + ")";
        }
    }
}
