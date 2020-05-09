using System;
using System.Collections.Generic;
using System.Text;

namespace MB
{
    class TwoDeck : Ship
    {
        public TwoDeck()
        {
            Name = "TwoDeck";
            Width = 2;
            DisplayShot = DisplayShot.TwoDeck;
        }
    }
}
