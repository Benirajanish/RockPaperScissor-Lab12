using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp89
{
    public class Player2 : Player 
    {
        Random random;

        public Player2(string name)
        {
            this.Name = name;

            random = new Random();
        }

       
        public override Roshambo GenerateRoshambo()
        {


             Roshambo RoshamboValue = (Roshambo)random.Next(3);

       
            return RoshamboValue;

        }
    }

}
