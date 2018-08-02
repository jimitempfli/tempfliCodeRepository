using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Food;

namespace Capstone.Classes
{
    public class VendingMenuCLI
    {
        private VendingMachine _vmObject = null;

        public VendingMenuCLI(VendingMachine vmObject)
        {
            _vmObject = vmObject;
        }
        public static void DisplayVM(VendingMachine vm)
        {
            //display the main machine , items, counts and cost
            //this keeps the UI portion in the CLI as required, and not in the vending machine object.
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------WELCOME TO VENDO MATIC 500----------");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("{0, -8}{1, -19}{2, -5}{3, -5}", "ItemID", "Name", "QTY", "Cost");
            Console.WriteLine();
            foreach (var item in vm.Inventory)
            {
                if (item.Value.Quantity == 0)
                {
                    Console.WriteLine("{0, -8}{1,-19}{2,-5}{3, -5}", item.Key, item.Value.FoodItem.Name, "Sold Out", "$" + item.Value.FoodItem.Price);
                }
                else
                {
                    Console.WriteLine("{0, -8}{1,-19}{2,-5}{3, -5}", item.Key, item.Value.FoodItem.Name, item.Value.Quantity, "$" + item.Value.FoodItem.Price);
                }
            }
            Console.WriteLine("----------------------------------------------");
        }
        public void VendingDisplay()
        {
            try
            {
                bool timeToExit = false;
                while (!timeToExit)
                {
                    Console.Clear();
                    //display the main VM
                    DisplayVM(_vmObject);

                    Console.WriteLine();
                    Console.WriteLine("(1) Feed Money.");
                    Console.WriteLine("(2) Select Item.");
                    Console.WriteLine("(3) Finish Transaction");
                    Console.WriteLine($"Current Money Provided: ${_vmObject.CurrentBalance}");
                    Console.WriteLine();
                    Console.Write("What option do you want to select? ");
                    string input = Console.ReadLine();

                    if (input == "1")
                    {
                        FeedMoneyCLI submenu = new FeedMoneyCLI(_vmObject);
                        submenu.FeedMoneyDisplay();
                    }
                    else if (input == "2")
                    {
                        SelectProductCLI submenu = new SelectProductCLI(_vmObject);
                        submenu.SelectProductDisplay(input);
                    }
                    else if (input == "3")
                    {
                        Console.Clear();
                        FinishTransaction();
                        
                        timeToExit = true;
                        Console.ReadKey();
                    }
                    else if (input == "q" || input == "Q")
                    {
                        timeToExit = true;
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Please try again");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File not found");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        //unnecessary, just put the makechange method in vending machine class
        Change change = new Change();

        public void FinishTransaction()
        {
            Console.WriteLine("Thank you for your purchase.");
            Console.WriteLine($"Your change is: ${_vmObject.CurrentBalance}");
            Console.ReadKey();
            change.MakeChange();
            
            //_vmObject.ResetBalance(); - have the vending machine reset the balance and return
            Console.ReadKey();
        }
    }
}


