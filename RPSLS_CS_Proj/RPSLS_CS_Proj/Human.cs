using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_CS_Proj
{
    public class Human : ParentClass
    {

        public Human(string name, int score) 
        {
            this.name = name;
            this.score = score;
            Console.WriteLine("{0} is created");
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

    }
}
