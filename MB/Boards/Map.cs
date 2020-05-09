using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB
{
    public class Map
    {
        public List<Panel> Panels { get; set; }
        public Map()
        {
            Panels = new List<Panel>();
            for(int i = 0; i <= 10; i++)
            {
                for(int j = 0; j <= 10; j++)
                {
                    Panels.Add(new Panel(i, j));
                }
            }
        }
    }
}
