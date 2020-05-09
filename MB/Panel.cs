using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB
{
    class Panel
    {
        public Cordinates Cordinates { get; set; }
        public DisplayShot DisplayShot { get; set; }
        public Panel(int row, int column)
        {
            Cordinates = new Cordinates(column, row);
            DisplayShot = DisplayShot.Empty;
        }
        public string Status
        {
            get
            {
                return DisplayShot.GetAttributeOfType<DescriptionAttribute>().Description;
            }
        }
        public bool IsOccupied
        {
            get
            {
                return DisplayShot == DisplayShot.FourDeck ||
                       DisplayShot == DisplayShot.ThreeDeck||
                       DisplayShot == DisplayShot.TwoDeck  ||
                       DisplayShot == DisplayShot.OneDeck;
            }
        }
        public bool IsRandomAvailable
        {
            get
            {
                return (Cordinates.Row % 2 == 0 && Cordinates.Column % 2 == 0)
                    || (Cordinates.Row % 2 == 1 && Cordinates.Column % 2 == 1);
            }
        }
    }
}
