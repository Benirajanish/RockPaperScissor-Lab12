using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp89
{
    public abstract class Player
    {
        private string name;
        private Roshambo roshambovalue;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Roshambo RoshamboValue
        {
            get { return roshambovalue; }
            set { roshambovalue = value; }
        }

      
        public abstract Roshambo GenerateRoshambo();


    }
}