using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp89
{
    class Program
    {
        static void Main(string[] args)
        {
            String P1Name = "";
            int myresults = 0;
            string Randomstr = "";
            string myselection = "";
            string playagain = "Y";
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine("Enter your Name:");
            string UserPlayer = Console.ReadLine();
            Console.WriteLine("Would you like to play against TheJets or TheSharks (j/s)?:");
            String player2 = Console.ReadLine();
            Player1Rock pr = new Player1Rock(P1Name);
            Player2 p2 = new Player2(P1Name);
            GameResult GR = new GameResult();

          
            while (playagain == "Y")
            {
                Console.WriteLine("Rock,Paper, or scissors?(R/P/S)");
                string selection = Console.ReadLine().ToUpper();

                if (selection == "R")
                {
                    myselection = "Rock";
                }
                else if (selection == "P")
                {
                     myselection = "Paper";
                }
                else if (selection == "S")
                {
                     myselection = "Scissors";
                }

                if (player2.ToLower() == "j")
                {
                    P1Name = "TheJets";
                    //   Console.WriteLine("Jets  " + myselection);


                    myresults = GR.RESULTS(pr.RoshamboValue.ToString(), myselection);

                }
                else
                {
                    P1Name = "TheSharks";
                    // Console.WriteLine("Auto Generte " + p2.RoshamboValue);

                        
                        Randomstr = p2.GenerateRoshambo().ToString();

              
                   
           //         Console.WriteLine("Auto Generte " + Randomstr + "    " + myselection);
                    myresults = GR.RESULTS(Randomstr, myselection);

                }

              
                    if (myresults == 0)
                {

                    Console.WriteLine("Draw!");
                }
                else if (myresults == 1)
                {
                    Console.WriteLine(P1Name + "    " + " Wins! ");
                }
                else if (myresults == 2)
                {
                    Console.WriteLine(UserPlayer + "    " + " Wins ");
                }

                Console.WriteLine("                  ");
                Console.WriteLine("Play again?(y/n):");
                playagain = Console.ReadLine().ToUpper();
            }
            Console.ReadLine();
           








        }
    }
}
