using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RPSLS_CS_Proj.Gameboard;



namespace RPSLS_CS_Proj
{
    public class Program
    {
        public static void Main()
        {
            Gameboard game = new Gameboard();
            game.runGame();
        }
    }
}

