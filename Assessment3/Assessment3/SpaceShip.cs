using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public class SpaceShip
    {
        public List<Astronaut> Astronauts { get; private set; }
        public SpaceShip()
        {
            Astronauts = new List<Astronaut>();
            {
                new Astronaut("Red", false);
                new Astronaut("Blue", false);
                new Astronaut("Green", false);
                new Astronaut("Pink", false);
                new Astronaut("Orange", false);
                new Astronaut("Yellow", false);
                new Astronaut("Black", false);
                new Astronaut("White", false);
                new Astronaut("Purple", true);
                new Astronaut("Brown", true);
            }
        }
        public void RemoveAstronaut(int index)
        {
            Astronauts.RemoveAt(index);
        }
        public bool LandSafely()
        {
            foreach(Astronaut aAstronaut in Astronauts)
            {
                if (aAstronaut.IsTraitor)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
