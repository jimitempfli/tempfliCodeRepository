using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine();
            VendingMenuCLI vmCLI = new VendingMenuCLI(vm);
            vm.LoadInventory();
            vmCLI.VendingDisplay();
        }
    }
}
