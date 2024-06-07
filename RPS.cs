using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class RPS
    {
        public Options Selection
        {
            get;
            set;
        }



        public Options Weakness
        {
            get 
            { 
                switch(Selection)
                {
                    case Options.Rock:
                        return Options.Paper;
                    case Options.Paper:
                        return Options.Scissors;
                    case Options.Scissors:
                        return Options.Rock;
                    default:
                        return Options.Undefined;
                }
            }
        }

    }
}
