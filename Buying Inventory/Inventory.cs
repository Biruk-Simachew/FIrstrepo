//Biruk SImachw
//2/6/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buying_Inventory
{
    public class Inventory
    {
        private int itemNumber = -1;

        //sets and gets
        public int ItemNumber
        {
            set { this.itemNumber = value; }
        }
        public void ShowPrice()
        {
            // Use a switch to display the price based on the item number
            switch (itemNumber)
            {
                case 1:
                    Console.WriteLine("Rope costs 10 gold.");
                    break;
                case 2:
                    Console.WriteLine("Torches cost 15 gold.");
                    break;
                case 3:
                    Console.WriteLine("Climbing Equipment costs 25 gold.");
                    break;
                case 4:
                    Console.WriteLine("Clean Water costs 1 gold.");
                    break;
                case 5:
                    Console.WriteLine("Machete costs 20 gold.");
                    break;
                case 6:
                    Console.WriteLine("Canoe costs 200 gold.");
                    break;
                case 7:
                    Console.WriteLine("Food Supplies cost 1 gold.");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please choose a number between 1 and 7.");
                    break;
            }
        }
    }
}
