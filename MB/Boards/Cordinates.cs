using System;
using System.Collections.Generic;
using System.Text;

namespace MB
{
    public class Cordinates
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public Cordinates(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
