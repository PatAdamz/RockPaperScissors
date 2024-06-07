using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Match.play = true;
            
            while(Match.play)
            {
                Match match = new Match();
                match.Player = new RPS(); 
                match.Computer = new RPS();
                
                match.ComputerMakeChoice();
                match.UserMakeChoice();
                match.result();

                Console.WriteLine("\r\nPlay again? Y/N");
                if (Console.ReadLine().ToUpper() == "N")
                {
                    Match.play = false;
                }
                else
                {
                    Console.Clear();
                }
            }

        }
    }
}
