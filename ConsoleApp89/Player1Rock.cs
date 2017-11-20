using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp89
{
    public class Player1Rock : Player
    {

        public Player1Rock(string name)
        {
            this.Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            this.RoshamboValue= Roshambo.Rock;
            return RoshamboValue;
        }
    }
}
