using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Poker_Game
{
    public class LoadCards
    {
        public static Image[] cards = new Image[52]; // array to hold the card faces
        public static int i = 0; // counter
        public static string[] filenames = Directory.GetFiles(@Directory.GetCurrentDirectory() + "\\cards"); // gets list of all images in our "cards" directory

        // load card faces into an array
        public static void GetImages()
        {
            foreach (var item in filenames)
            {
                cards[i] = Image.FromFile(item);
                i++;
            }
        }
    }
}