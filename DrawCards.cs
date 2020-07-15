using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Game
{
    internal class DrawCards
    {
        public static int Draw(List<int> shuffled)
        {
            int cardValue = shuffled[0];
            shuffled.RemoveAt(0);

            return cardValue;
        }
    }
}