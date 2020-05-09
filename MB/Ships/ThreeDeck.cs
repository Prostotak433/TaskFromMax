using System;
using System.Collections.Generic;
using System.Text;

namespace MB
{
    class ThreeDeck : Ship
    {
        public ThreeDeck()
        {
            Name = "ThreeDeck";
            Width = 3;
            DisplayShot = DisplayShot.ThreeDeck;
        }
    }
}
