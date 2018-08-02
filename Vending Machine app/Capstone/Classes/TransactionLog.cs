using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Food;

namespace Capstone.Classes
{
    public class TransactionLog
    {
        //methods
        //RecordPurchase method is called in the "DispenseItem" method found in Vending Machine class.
        
        public static string _directory = Environment.CurrentDirectory;
        public static string _filename = "Log.txt";
        public string _fullPath = Path.Combine(_directory, _filename);

        public void RecordPurchase() //pass in item and current balance
        {
            //this method is used the "DispenseItem" method found in VendingMachine class
            //required to log 
            using (StreamWriter sw = new StreamWriter(_filename, false))
            {
                sw.WriteLine(DateTime.UtcNow + " ");
                sw.WriteLine($"Dispensed x item, y price...");
            }
        }

        //constructor - this would take in file name for the log
        public TransactionLog()
        {

        }
    }
}
