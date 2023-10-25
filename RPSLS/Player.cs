using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal abstract class Player
    {
        //Member Variabes (HAS A)
        public string name;
        public List<string> gestures;
        public string chosenGesture;
        public int score;

        //Constructor
        public Player(string name)
        {
            this.name = name;
            gestures = new List<string> {"rock", "paper", "scissors", "lizard", "spock" };
            chosenGesture = "";
            score = 0;
        }

        //Member Methods (CAN DO)
        //This abstract method must be overridden by the child Player classes
        public abstract void ChooseGesture();
    }
    class HumanPlayer: Player
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
    class ComputerPlayer : Player
    {
        public ComputerPlayer() : base("Computer") { }

        
        public override void ChooseGesture()
        {
            Random random = new Random();
            int index = random.Next(gestures.Count);
            chosenGesture = gestures[index];
        }
    }
        



            
        
    

}
