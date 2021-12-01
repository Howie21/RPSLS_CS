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


        }

        public int decidePlayers()
        {
            Console.WriteLine("Enter Number of Human Players:");
            string players = Console.ReadLine();
            int numberOfPlayers = Convert.ToInt32(players);

            return numberOfPlayers;
        }

        public string getPlayerName()
        {
            Console.WriteLine("Please Enter the Players name!:");
            return Console.ReadLine();
        }

        public void createPlayers(int humanPlayers)
        {
            if(humanPlayers == 1)
            {
                string name = getPlayerName();
                Human player1 = new Human(name, 0);
                this.players.Add(player1);
            }
        }

    }
}
