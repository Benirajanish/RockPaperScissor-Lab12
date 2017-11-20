using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp89
{
    class GameResult
    {
        public int RESULTS(string ip1, string ip2)
        {

            int RetReult = 0;


            if (ip1 == ip2)
            {
                //     Console.WriteLine("one");
                RetReult = 0;
            }
            else if ((ip1 == "Paper" && ip2 == "Rock") || (ip1 == "Rock" && ip2 == "Scissors") || (ip1 == "Scissors" && ip2 == "Paper"))
            {
                //    Console.WriteLine("three");
                RetReult = 1;
            }
            else
            { 
                RetReult = 2;
            }
         
            // Console.WriteLine("test" + "    " + ip1 + "    " + ip2  + "    " + RetReult);
            return RetReult;
        }



    }
}
