using System;
using System.Collections.Generic;
using System.Text;

namespace MB
{
    public abstract class Ship
    {
        public string Name { get; set; }
        public int Hits { get; set; }
        public int Width { get; set; }
        public DisplayShot DisplayShot { get; set; }
        public bool IsSunk
        {
            get
            {
                return Hits >= Width;
            }
        }
    }
}
