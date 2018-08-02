using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Capstone.Classes;
using Capstone.Food;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class SelectProductCLI
    {
        private VendingMachine _vmObject = null;

        public SelectProductCLI(VendingMachine vmObject)
        {
            _vmObject = vmObject;
        }
      
        public void SelectProductDisplay(string input)
        {
            Console.WriteLine();
            Console.WriteLine($"Current Money Provided: ${_vmObject.CurrentBalance}");
            Console.WriteLine("Select a Product: ");

            input = Console.ReadLine().ToLower();
            _vmObject.DispenseItem(input);
        }
    }
}
