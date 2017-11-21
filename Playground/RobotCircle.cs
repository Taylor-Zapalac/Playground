using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    /// <summary>
    /// Given a series of commands as UDLR characters(Up, Down, Left, Right)
    /// See if it makes a circle... aka end up in the same spot.
    /// </summary>
    class RobotCircle
    {
        public bool didHeDoACircle(String moves)
        {
            int x = 0;
            int y = 0;
            bool circle = true;

            foreach(char c in moves)
            {
                if (c.Equals('R')) y++;
                else if (c.Equals('L')) y--;
                else if (c.Equals('U')) x++;
                else if (c.Equals('D')) x--;
            }

            if (x == 0 && y == 0) circle = true;
            else circle = false;

            return circle;
        }
    }
}
