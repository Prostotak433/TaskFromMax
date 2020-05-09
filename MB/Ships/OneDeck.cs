using System;
using System.Collections.Generic;
using System.Text;

namespace MB
{
    class OneDeck : Ship
    {
        public OneDeck()
        {
            Name = "OneDeck";
            Width = 1;
            DisplayShot = DisplayShot.OneDeck;
        }
    }
}
