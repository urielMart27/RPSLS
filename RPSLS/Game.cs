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

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("Choose number of players: Enter 1 or 2");
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
           
        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();

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
