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

        public void incrementScore()
        {
            this.score++;
            Console.WriteLine("{0}'s score was incremented by 1", this.name);
        }

       




    }
}
