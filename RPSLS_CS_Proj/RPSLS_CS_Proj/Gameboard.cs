using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static RPSLS_CS_Proj.Human;
using static RPSLS_CS_Proj.AI;
using static RPSLS_CS_Proj.Player

namespace RPSLS_CS_Proj
{
    public class Gameboard
    {

        public int roundCount;
        public List<Player> players;

        public Gameboard(int roundCount) 
        { 
            this.roundCount = roundCount;
            this.players = new List<Player>();
            Console.WriteLine("Gameboard Created");
        }

        public void runGame()
        {
            Console.WriteLine("Starting Game...");
            int numberOfPlayers = decidePlayers();
            createPlayers(numberOfPlayers);
            if(numberOfPlayers == 1)
            {
                playerVsAI();
            }
            else
            {
                playerVsPlayer();
            }

        }

        public int decidePlayers()
        {
            int numberOfPlayers = 0;
            do
            {
                Console.WriteLine("Enter Number of Human Players: (no more then 2)");
                string players = Console.ReadLine();
                numberOfPlayers = Convert.ToInt32(players);
            }
            while(numberOfPlayers == 0 || numberOfPlayers > 2);
            

            return numberOfPlayers;
        }

        public string getPlayerName()
        {
            Console.WriteLine("Please Enter the Players name!:");
            string userInput = "";
            do
            {
               userInput = Console.ReadLine();
            }
            while (userInput == "");
            return userInput;
        }

        public bool verifyInput(string userInput)
                {
                       bool verification;

                       switch (userInput)
                       {
                           case "rock":
                               verification = true; 
                               break;
                           case "paper":
                               verification = true;
                               break;
                           case "scissors":
                               verification= true;
                               break;
                           case "lizard":
                               verification = true;
                               break;
                           case "spock":
                               verification = true;
                               break;
                           default:
                               verification = false;
                               break;
                       }

                       return verification;
                }

        public string getPlayerGesture(Player player)
        {
            bool verify = false;
            string gesture = "";
            do
            {
                string input = Console.ReadLine();
                gesture = input.ToLower();
                verify = verifyInput(gesture);
            }
            while (verify == false || gesture == "");
            
            return gesture;

        }

        public void createPlayers(int humanPlayers)
        {
            if(humanPlayers == 1)
            {
                string name = getPlayerName();
                Human player1 = new Human(name, 0);
                this.players.Add(player1);
                AI player2 = new AI("Nevin", 0);
                this.players.Add(player2);
            }
            else
            {
                for(int i = 0; i < humanPlayers; i++)
                {
                    string name = getPlayerName();
                    Human player = new Human(name, 0);
                    this.players[i] = player;
                    Console.WriteLine("{0} was created as a Human Player", player.name);
                }
            }
        }

        public int chooseWinner(string player1Gesture, string player2Gesture)
        {
            int winner = 0;

            if (player1Gesture == "rock")
            {
                if(player2Gesture == "scissors")
                {
                    winner = 1;
                }
                else if(player2Gesture== "lizard")
                {
                    winner = 1;
                }
                else { winner = 2; }
            }
            else if( player1Gesture == "scissors")
            {
                if( player2Gesture == "paper")
                {
                    winner = 1;
                }
                else if(player2Gesture == "lizard")
                {
                    winner =1;
                }
                else { winner = 2; }
            }
            else if(player1Gesture == "paper")
            {
                if(player2Gesture == "rock")
                {
                    winner =1;
                }
                else if( player2Gesture == "spock")
                {
                    winner = 1;
                }
                else { winner = 2; }
            }
            else if(player1Gesture == "lizard")
            {
                if(player2Gesture == "spock")
                {
                    winner = 1;
                }
                else if(player2Gesture == "paper")
                {
                    winner = 1;
                }
                else { winner = 2; }
            }
            else if(player1Gesture == "spock")
            {
                if(player2Gesture == "rock")
                {
                    winner = 1;
                }
                else if(player2Gesture == "scissors")
                {
                    winner = 1;
                }
                else { winner = 2; }
            }

            return winner;
        }

        public void playerVsPlayer()
        {
            Player players1 = this.players[0];
            Player players2 = this.players[1];


            Console.WriteLine("This is a first to 3 match. Once someone reaches 3, that player will be the winner. ");
            do
            {
                Console.WriteLine("Gestures to choose from are:");
                Console.WriteLine("Rock, Paper, Scissors, Lizard and Spock\n");
                Console.WriteLine("{0} choose your gesture", players1.name);
                string player1Input = getPlayerGesture(players1);
                Console.WriteLine("{0} choose your gesture", players2.name);
                string player2Input = getPlayerGesture(players2);
                int winner = chooseWinner(player1Input, player2Input);
            }
            while (players1.score < 3 && players2.score < 3);
           
        }

        public void playerVsAI()
        {

        }

    }
}
