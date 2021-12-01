using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_CS_Proj
{
    public abstract class ParentClass
    {
        public string name;
        public int score;

        public void ModifyScore()
        {
            this.score++;
            Console.WriteLine("{0}'s score was incremented by 1", this.name);
        }

        public bool verifyInput(string userInput)
        {
            bool verification = false;

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




    }
}
