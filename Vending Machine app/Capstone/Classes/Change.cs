using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Food;

namespace Capstone.Classes
{
    public class Change
    {
        private VendingMachine _vmObject = null;

        //member variables initialized
        public int _nickels = 0;
        public int _dimes = 0;
        public int _quarters = 0;
        public decimal newBalance = 0;

        public const int quarterValue = 25;
        public const int dimeValue = 10;
        public const int nickleValue = 5;
        
        //these properties will allow us to return the *quantity of* 
        //each type of coin, not the values of the coins
        public int Nickels
        {
            get
            {
                return _nickels;
            }
        }
        public int Dimes
        {
            get
            {
                return _dimes;
            }
        }
        public int Quarters
        {
            get
            {
                return _quarters;
            }
        }
     


        //this can be in vending machine class
        //all change by coin only, starting with quarters.
        public void MakeChange()
        {
            newBalance =_vmObject.CurrentBalance;
            newBalance *= 100;
            
            _quarters = Convert.ToInt32(newBalance) / quarterValue;
            _dimes = Convert.ToInt32(newBalance) % quarterValue / dimeValue;
            _nickels = Convert.ToInt32(newBalance) % quarterValue % dimeValue / nickleValue;

            //return a string and return it to the CLI
            Console.WriteLine($"{_quarters} Quarters");
            Console.WriteLine($"{_dimes} Dimes");
            Console.WriteLine($"{_nickels} Nickles");
            
        }
    }
}
