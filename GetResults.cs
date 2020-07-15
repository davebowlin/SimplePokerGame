using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Poker_Game
{
    internal class GetResults
    {
        public static string Results(int one, int two, int three)
        {
            if (((three > one) && (three < two)) || (three > two) && (three < one))
            {
                return "winhand";
            }
            else if ((three == one) || (three == two))
            {
                return "doubleloss";
            }
            else
            {
                return "losthand";
            }
        }
    }
}