using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Match
    {
        public RPS Player { get; set; }
        public RPS Computer { get; set; }

        public static bool play { get; set; }

        public Match()
        {
            Console.WriteLine("Lets play rock, paper scissors!\r\n");
        }

        public void ComputerMakeChoice()
        {
                Random Choice = new Random();
                Computer.Selection = Selection.GetEnum(Choice.Next(0, 3).ToString());
        }

        public void UserMakeChoice()
        {

            Console.WriteLine("\r\nEnter a number 0-2 to make a selection.\r\n");

            Enum.GetNames(typeof(Options))
                .ToList()
                .ForEach(x => 
                { 
                    if(x != "Undefined")
                    {
                        Console.WriteLine($"{(int)Enum.Parse(typeof(Options), x)}.{x}");
                    }
                    
                });

            string userSelection = Console.ReadLine();

            if(Selection.ValidValue(userSelection))
            {
                Player.Selection = Selection.GetEnum(userSelection);
            }
            else
            {
                Console.WriteLine($"Input {userSelection} is not valid.\r\n");
                UserMakeChoice();
            }
        }

        public void result()
        {
            if (Computer.Weakness == Player.Selection)
            {
                Console.WriteLine($"Computer chose {Computer.Selection}. You win!");
            }
            else if (Computer.Selection == Player.Selection)
            {
                Console.WriteLine($"Computer chose {Computer.Selection}. Result is a Draw!");
            }
            else
            {
                Console.WriteLine($"Computer chose {Computer.Selection}. You lose!");
            }
        }
    }
}
