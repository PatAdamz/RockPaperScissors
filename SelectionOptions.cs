using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public enum Options
    {
        Rock,
        Paper,
        Scissors,
        Undefined
    }

    public static class Selection
    {
        public static bool ValidValue(string selection)
        {
            switch(selection) 
            {
                case "0":
                    return true;
                case "1":
                    return true;
                case "2":
                    return true;

                default: 
                    return false;
            }
        }

        public static Options GetEnum(string selection)
        {
            return (Options)Enum.Parse(typeof(Options), Enum.GetName(typeof(Options), Int32.Parse(selection)));
        }


    }
}
