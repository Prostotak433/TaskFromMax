using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB
{
    public enum DisplayShot
    {
        [Description("o")]
        Empty,
        [Description("1")]
        FourDeck,
        [Description("2")]
        ThreeDeck,
        [Description("3")]
        TwoDeck,
        [Description("4")]
        OneDeck,
        [Description("X")]
        Hit,
        [Description("M")]
        Miss    
    }
}
