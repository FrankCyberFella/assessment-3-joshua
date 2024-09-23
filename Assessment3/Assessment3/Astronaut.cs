using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public class Astronaut
    {
        public string SuitColor { get; set; }
        public bool IsTraitor { get; set; }
        public Astronaut(string color, bool isTraitor)
        {
            SuitColor = color;
            IsTraitor = isTraitor;
        }
    }
}
