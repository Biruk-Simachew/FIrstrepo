//Biruk Simachew
//2/13/25
namespace Simula_s_Test
{
    public class Program
    {
        public enum ChestState
        {
            Locked,
            Unlocked,
            Open
        }
        public static void Main(string[] args)
        {
            ChestState chestState = ChestState.Locked;

            while (true)
            {
                Console.WriteLine($"The chest is {chestState}. What do you want to do?");
                string command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "lock":
                        if (chestState == ChestState.Unlocked)
                        {
                            chestState = ChestState.Locked;
                            Console.WriteLine("The chest is now locked.");
                        }
                        else
                        {
                            Console.WriteLine("You can't lock the chest right now.");
                        }
                        break;

                    case "unlock":
                        if (chestState == ChestState.Locked)
                        {
                            chestState = ChestState.Unlocked;
                            Console.WriteLine("The chest is now unlocked.");
                        }
                        else
                        {
                            Console.WriteLine("You can't unlock the chest right now.");
                        }
                        break;

                    case "open":
                        if (chestState == ChestState.Unlocked)
                        {
                            chestState = ChestState.Open;
                            Console.WriteLine("The chest is now open.");
                        }
                        else
                        {
                            Console.WriteLine("You can't open the chest right now.");
                        }
                        break;

                    case "close":
                        if (chestState == ChestState.Open)
                        {
                            chestState = ChestState.Unlocked;
                            Console.WriteLine("The chest is now closed.");
                        }
                        else
                        {
                            Console.WriteLine("You can't close the chest right now.");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid command. Please enter lock, unlock, open, or close.");
                        break;
                }
            }
        }
    }
    }
