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



    }
}
