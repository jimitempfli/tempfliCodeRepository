using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Classes;
using Capstone.Food;

namespace Capstone.Classes
{
    public class FeedMoneyCLI
    {
        private VendingMachine _vmObject = null;

        public FeedMoneyCLI(VendingMachine vmObject)
        {
            _vmObject = vmObject;
        }
        public void FeedMoneyDisplay()
        {
            bool timeToExit = false;
            while (!timeToExit)
            {
                Console.Clear();
                //display the main VM
                VendingMenuCLI.DisplayVM(_vmObject);
                Console.WriteLine();
                Console.WriteLine("Feed in Your Money");
                Console.WriteLine();
                Console.WriteLine("(1) $1");
                Console.WriteLine("(2) $2");
                Console.WriteLine("(3) $5");
                Console.WriteLine("(4) $10");
                Console.WriteLine("(M) Return to Main Menu");
                Console.WriteLine();
                Console.WriteLine($"Current Money Provided: ${_vmObject.CurrentBalance}");
                Console.WriteLine();
                Console.Write("Select Your Bill Type: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    _vmObject.FeedMoney(1M);
                }
                else if (input == "2")
                {
                    _vmObject.FeedMoney(2M);
                }
                else if (input == "3")
                {
                    _vmObject.FeedMoney(5M);
                }
                else if (input == "4")
                {
                    _vmObject.FeedMoney(10M);
                }
                else if (input == "m" || input == "M")
                {
                    timeToExit = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
    }
}
