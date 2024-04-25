using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class Program
    {

        public static List<string> Options = new List<string>()
        {
            "Rock",
            "Paper",
            "Scissors"
        };

        public static string result(int PlayerChoice, int ComputerChoice)
        {
            RPS Player = new RPS(PlayerChoice);
            RPS Computer = new RPS(ComputerChoice);
            
            if(Computer.Weakness == Player.Selection)
            {
               return $"Computer chose {Computer.Selection}. You win!";
            }
            else if (Computer.Selection == Player.Selection)
            {
                return $"Computer chose {Computer.Selection}. Result is a Draw!";
            }
            else
            {
                return $"Computer chose {Computer.Selection}. You lose!";
            }

        }

        public static int ComputerMakeChoice()
        {
            Random Choice = new Random();
            return  Choice.Next(1, 4);
        }

        public static int UserMakeChoice()
        {
            int selection;

            Console.WriteLine("\r\nEnter a number 1-3 to make a selection.\r\n");

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"\t{i}.{Options[i - 1]}");
            }

            selection = Convert.ToInt32(Console.ReadLine());

            return selection;

        }

        static void Main(string[] args)
        {
            bool play = true;
            int PlayerChoice;
            int ComputerChoice;
            Console.WriteLine("Lets play rock, paper scissors!\r\n");

            while(play)
            {
                ComputerChoice = ComputerMakeChoice();
                PlayerChoice = UserMakeChoice();
                Console.WriteLine(result(PlayerChoice, ComputerChoice));

                Console.WriteLine("\r\nPlay again? Y/N");
                if (Console.ReadLine().ToUpper() == "N")
                {
                    break;
                }
            }

        }
    }
}
