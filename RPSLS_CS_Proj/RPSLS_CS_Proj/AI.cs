using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_CS_Proj
{
    public class AI : ParentClass
    {
        public List<string> gestures;

        public AI(string name, int score)
        {
            this.name = name;
            this.score = score;
            this.gestures = new List<string>();
            createGestures();
            Console.WriteLine("AI {0} Online", name);
        }

        public void createGestures()
        {
            this.gestures.Add("rock");
            this.gestures.Add("paper");
            this.gestures.Add("scissors");
            this.gestures.Add("lizard");
            this.gestures.Add("spock");
        }

        public string randomGesture()
        {
            Random rnd = new Random();
            int index = rnd.Next(5);
            Console.WriteLine(this.gestures[index]);
            return this.gestures[index];
        }

    }
}
