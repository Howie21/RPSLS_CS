using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_CS_Proj
{
    public class AI : ParentClass
    {

        public AI(string name, int score)
        {
            this.name = name;
            this.score = score;
            Console.WriteLine("AI {0} Online", name);
        }
        

    }
}
