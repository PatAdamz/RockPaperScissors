using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class RPS
    {
        public int ID
        {
            get;
            set;
        }

        public string Selection
        {
            get 
            {
                switch (ID)
                {
                    case 1:
                        return "Rock";
                    case 2:
                        return "Paper";
                    case 3:
                        return "Scissors";
                    default:
                        return "Undefined";
                }
            }
        }

        public string Weakness
        {
            get 
            { 
                switch(Selection)
                {
                    case "Rock":
                        return "Paper";
                    case "Paper":
                        return "Scissors";
                    case "Scissors":
                        return "Rock";
                    default:
                        return "Undefined";
                }
            }
        }


       public RPS(int id)
        {
            ID = id;
        }
    }
}
