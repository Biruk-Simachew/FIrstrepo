namespace Boss_Battle_Hunting_the_Manticore
{
    public class Program
    {
        public static void Main(string[] args)
        {
         
            int cityHealth = 15;
            int manticoreHealth = 10;
            int round = 1;

            Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
            int manticoreDistance = int.Parse(Console.ReadLine());
            Console.Clear();

            while (cityHealth > 0 && manticoreHealth > 0)
            {
                Console.WriteLine($"STATUS: Round: {round} City: {cityHealth}/15 Manticore: {manticoreHealth}/10");
                int damage = CalculateDamage(round);
                Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");

                Console.Write("Enter desired cannon range: ");
                int targetRange = int.Parse(Console.ReadLine());

                if (targetRange == manticoreDistance)
                {
                    Console.WriteLine("That round was a DIRECT HIT!");
                    manticoreHealth -= damage;
                }
                else if (targetRange > manticoreDistance)
                {
                    Console.WriteLine("That round OVERSHOT the target.");
                }
                else
                {
                    Console.WriteLine("That round FELL SHORT of the target.");
                }

                if (manticoreHealth > 0)
                {
                    cityHealth--;
                }

                round++;
                Console.WriteLine("-----------------------------------------------------------");
            }

            if (manticoreHealth <= 0)
            {
                Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
            }
            else
            {
                Console.WriteLine("The city of Consolas has been destroyed!");
            }
        }

        public static int CalculateDamage(int round)
        {
            if (round % 3 == 0 && round % 5 == 0)
            {
                return 10;
            }
            else if (round % 3 == 0 || round % 5 == 0)
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }
    }
    }

