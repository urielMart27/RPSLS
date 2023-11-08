using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer:Player
    {
        public HumanPlayer(string name) : base(name) { }

        public override void ChooseGesture()
        {

            Console.WriteLine("Here are your options:");
            Console.WriteLine("Rock");
            Console.WriteLine("Paper");
            Console.WriteLine("Scissors");
            Console.WriteLine("Lizard");
            Console.WriteLine("Spock");
            Console.WriteLine("Which do you choose?");

            while (true)
            {
                string choice = Console.ReadLine().ToLower();
                Console.WriteLine();
                if (choice == "rock" || choice == "paper" || choice == "scissors" || choice == "lizard" || choice == "spock")
                {
                    chosenGesture = choice;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }

        }
    }
}
