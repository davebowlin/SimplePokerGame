using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker_Game
{
    internal class ShuffleCards
    {
        public static List<int> shuffled = new List<int>(); // used to shuffle the cards into a list
        public static Random random = new Random(Guid.NewGuid().GetHashCode()); // generate randoms based on random seeds

        public static List<int> Shuffle()
        {
            do
            {
                int getcards = random.Next(0, 52);
                if (!shuffled.Contains(getcards))
                {
                    shuffled.Add(getcards);
                }
            } while (shuffled.Count < 52);

            return shuffled;
        }

        public static int GetValues(int value)
        {
            switch (value)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    value = 14;
                    break;

                case 4:
                case 5:
                case 6:
                case 7:
                    value = 2;
                    break;

                case 8:
                case 9:
                case 10:
                case 11:
                    value = 3;
                    break;

                case 12:
                case 13:
                case 14:
                case 15:
                    value = 4;
                    break;

                case 16:
                case 17:
                case 18:
                case 19:
                    value = 5;
                    break;

                case 20:
                case 21:
                case 22:
                case 23:
                    value = 6;
                    break;

                case 24:
                case 25:
                case 26:
                case 27:
                    value = 7;
                    break;

                case 28:
                case 29:
                case 30:
                case 31:
                    value = 8;
                    break;

                case 32:
                case 33:
                case 34:
                case 35:
                    value = 9;
                    break;

                case 36:
                case 37:
                case 38:
                case 39:
                    value = 10;
                    break;

                case 40:
                case 41:
                case 42:
                case 43:
                    value = 11;
                    break;

                case 44:
                case 45:
                case 46:
                case 47:
                    value = 12;
                    break;

                case 48:
                case 49:
                case 50:
                case 51:
                    value = 13;
                    break;

                default:
                    break;
            }

            return value;
        }

        public static int Draw()
        {
            int cardValue = shuffled[0];
            shuffled.RemoveAt(0);

            return cardValue;
        }
    }
}