using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capstone.Food;

namespace Capstone.Classes
{
    public class FinalReport
    {
        public static string _directory = Environment.CurrentDirectory;
        public static string _filename = "Final_Report.txt";
        public string _fullPath = Path.Combine(_directory, _filename);

        //this method is used the "DispenseItem" method found in VendingMachine class
        //required to log total sales in final report - need work
        public void TotalItemsBought()
        {
            using (StreamWriter sw = new StreamWriter(_filename, false))
            {
                sw.WriteLine(DateTime.UtcNow + " ");
                sw.WriteLine($"Dispensed an item, still figuring how to get the details...");
            }
        }

        //constructor
        public FinalReport()
        {
            //pass in the file name here
            //check if is path rooted ...
        }

    }
}

       