using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Convert;
using static RPSLS_CS_Proj.Human;
using static RPSLS_CS_Proj.AI;

namespace RPSLS_CS_Proj
{
    public class Gameboard
    {

        public int roundCount;
        public List<object> players;

        public Gameboard(int roundCount) 
        { 
            this.roundCount = roundCount;
            this.players = new List<object>();
            Console.WriteLine("Gameboard Created");
        }

        public void runGame()
        {
            Console.WriteLine("Starting Game...");
            int numberOfPlayers = decidePlayers();
            createPlayers(numberOfPlayers);


        }

        public int decidePlayers()
        {
            Console.WriteLine("Enter Number of Human Players: (no more then 2)");
            string players = Console.ReadLine();
            int numberOfPlayers = Convert.ToInt32(players);

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


    }
}
