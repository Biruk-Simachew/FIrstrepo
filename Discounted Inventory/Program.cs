//Biruk SImacgew
//2/6/2025
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System;

namespace Buying_Inventory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The following items are available:\n1 – Rope\n2 – Torches\n3 – Climbing Equipment\n4 – Clean Water\n5 – Machete\n6 – Canoe\n7 – Food Supplies\nWhat number do you want to see the price of?");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Whats your name? ");
            string Name=Console.ReadLine();
            Inventory inventory = new Inventory();
            
            inventory.ItemNumber = choice;
            inventory.Name = Name;

            inventory.ShowPrice();
        }
    }
}
