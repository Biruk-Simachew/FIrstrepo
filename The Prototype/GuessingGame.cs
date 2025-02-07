//Biruk SImachew
//2/6/25
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Prototype
{
    public class GuessingGame
    {
        public void StartGame()
        {
           
            Console.Write("User 1, enter a number between 0 and 100: ");
            int targetNumber = int.Parse(Console.ReadLine());

            
            Console.Clear();

            int guess;
            bool isCorrect = false;
            while (!isCorrect)
            {
             
                Console.Write("User 2, guess the number.\nWhat is your next guess? ");
                guess = int.Parse(Console.ReadLine());

               
                if (guess < targetNumber)
                {
                    Console.WriteLine($"{guess} is too low.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine($"{guess} is too high.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! {guess} is correct!");
                    isCorrect = true;
                }
            }
        }
    }
}
