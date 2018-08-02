using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Food;

namespace Capstone.Classes
{
    public class VendingMachine
    {
        //member variables
        //Keep All of these as is:
        private decimal _currentBalance = 0;
        private Dictionary<string, InventoryItem> _inventory = new Dictionary<string, InventoryItem>();
        public Dictionary<string, InventoryItem> Inventory
        {
            get
            {
                return new Dictionary<string, InventoryItem>(_inventory);
            }
        }
        public decimal CurrentBalance
        {
            get
            {
                return _currentBalance;
            }
        }
        public string FilePath { get; set; } = @"C:\Workspace\team\team3-c-week4-pair-exercises\c#-capstone\etc\vendingmachine.csv";

        //in here will need to reference the files for log and report class - 
        //See Below in method "DispenseItem" - we will track sales and transactions at each purchase...
        public TransactionLog allTransactionsLog = new TransactionLog();
        public FinalReport outputReport = new FinalReport();
        
        // methods
        public void LoadInventory()
        {
            List<string> lines = File.ReadAllLines(FilePath).ToList();
            foreach (string line in lines)
            {
                List<string> lineSplit = line.Split('|').ToList();

                if (lineSplit[3] == Food.Food.Chip)
                {
                    Chips foodItem = new Chips(lineSplit[1], decimal.Parse(lineSplit[2]));
                    InventoryItem inventoryItem = new InventoryItem(foodItem);
                    _inventory.Add(lineSplit[0], inventoryItem);
                }
                else if (lineSplit[3] == Food.Food.Candy)
                {
                    Candy foodItem = new Candy(lineSplit[1], decimal.Parse(lineSplit[2]));
                    InventoryItem inventoryItem = new InventoryItem(foodItem);
                    _inventory.Add(lineSplit[0], inventoryItem);
                }
                else if (lineSplit[3] == Food.Food.Drink)
                {
                    Drink foodItem = new Drink(lineSplit[1], decimal.Parse(lineSplit[2]));
                    InventoryItem inventoryItem = new InventoryItem(foodItem);
                    _inventory.Add(lineSplit[0], inventoryItem);
                }
                else if (lineSplit[3] == Food.Food.Gum)
                {
                    Gum foodItem = new Gum(lineSplit[1], decimal.Parse(lineSplit[2]));
                    InventoryItem inventoryItem = new InventoryItem(foodItem);
                    _inventory.Add(lineSplit[0], inventoryItem);
                }
                else
                {
                    throw new Exception("Invalid Food Type");
                }
            }
        }

        public void FeedMoney(decimal amount)
        {
            _currentBalance += amount;
        }

        // this method dispenses item, updates QTY, updates customer total balance
        // and also records each sale and transaction in both the FinalReport and TransactionLog.txt
        public void DispenseItem(string input)
        {
            if(_inventory.ContainsKey(input) && _inventory[input].Quantity > 0)
            {
                decimal price = _inventory[input].FoodItem.Price;

                _currentBalance -= price;
                _inventory[input].Quantity--;
                allTransactionsLog.RecordPurchase();
                outputReport.TotalItemsBought();
            }
            else if (_inventory[input].Quantity == 0)
            {
                //return a string instead?
                throw new Exception("Item sold out.");
            }
            else
            {
                throw new Exception ("Invalid Location.");
            }
        }
       

        private void ResetBalance()
        {
            _currentBalance = 0;
        }

        private VendingMenuCLI _vmCLI = null;



        //constructor
        public VendingMachine(VendingMenuCLI vmCLI)
        {
            _vmCLI = vmCLI;
        }
        //also need this default constructor as used elsewhere in app - important to keep as is.
        public VendingMachine()
        {

        }
    }
}
