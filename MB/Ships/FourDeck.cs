using System;
using System.Collections.Generic;
using System.Text;

namespace MB
{
    class FourDeck : Ship
    {
        public FourDeck()
        {
            Name = "FourDeck";
            Width = 4;
            DisplayShot = DisplayShot.FourDeck;
        }
    }
}
