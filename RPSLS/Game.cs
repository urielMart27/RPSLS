using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {
            WelcomeMessage();
            int numberOfHumanPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numberOfHumanPlayers);
            RunGame();
            
        }
        

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            
            {
                Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
                Console.WriteLine("Rock crushes Scissors");
                Console.WriteLine("Scissors cuts paper");
                Console.WriteLine("Paper covers Rock");
                Console.WriteLine("Rock crushes Lizard");
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine("Spock smashes Scissors");
                Console.WriteLine("Scissors decapitates Lizard");
                Console.WriteLine("Lizard eats Paper");
                Console.WriteLine("Paper disproves Spock");
                Console.WriteLine("Spock vaporizes Rock");
                Console.WriteLine();
                Console.WriteLine("The Game will be best out of 3");
                Console.WriteLine();
            }
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("Choose number of players: Enter 1 or 2");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return input;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
           if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("What is your name?");
                string PlayerName = Console.ReadLine();
                Console.WriteLine();
                playerOne = new HumanPlayer(PlayerName);
                playerTwo = new ComputerPlayer();

               
            }
           else if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Enter Player 1's name:");
                string PlayerOneName = Console.ReadLine();

                Console.WriteLine("Enter Player 2's name:");
                string PlayerTwoName = Console.ReadLine();
                
                playerOne = new HumanPlayer(PlayerOneName);
                playerTwo = new HumanPlayer(PlayerTwoName);
            }
        }

        public void CompareGestures()
        {

            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerOne.chosenGesture == "rock" && (playerTwo.chosenGesture == "lizard" || playerTwo.chosenGesture == "scissors")) ||
                (playerOne.chosenGesture == "paper" && (playerTwo.chosenGesture == "rock" || playerTwo.chosenGesture == "spock")) ||
                (playerOne.chosenGesture == "scissors" && (playerTwo.chosenGesture == "paper" || playerTwo.chosenGesture == "lizard")) ||
                (playerOne.chosenGesture == "lizard" && (playerTwo.chosenGesture == "paper" || playerTwo.chosenGesture == "spock")) ||
                (playerOne.chosenGesture == "spock" && (playerTwo.chosenGesture == "rock" || playerTwo.chosenGesture == "scissors")))

            {
                Console.WriteLine($"{playerOne.name} wins this round!");
                playerOne.score++;
            }
            else 
            {
                Console.WriteLine($"{playerTwo.name} wins this round!");
                playerTwo.score++;
            } 

        }

        public void DisplayGameWinner()
        {
            if (playerOne.score >= 2)
            {
                Console.WriteLine($"{playerOne.name} wins the game!");
            }
            else if (playerTwo.score >= 2)
            {
                Console.WriteLine($"{playerTwo.name} wins the game!");
                
            }
            
        }

        public void RunGame()
        {

            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();

                Console.WriteLine($"{playerOne.name} chose {playerOne.chosenGesture}");
                Console.WriteLine($"{playerTwo.name} chose {playerTwo.chosenGesture}");
                CompareGestures();
                Console.WriteLine($"Scores: {playerOne.name}: {playerOne.score}, {playerTwo.name}: {playerTwo.score}");
                Console.WriteLine();
                DisplayGameWinner();

            }


            //Display the rules of the game
            // Ask how many players will be playing
            // if one: make one a computer player and one human player
            // if two: make both of them human players
            // Display list of gestures 
            // Make player or players choose a gesture
            // Display the player that wins the round 
            // First player to three wins the game.
        }
    }

}
