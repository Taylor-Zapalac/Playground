using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class RobotCircle
    {

        /*
         * 
         * Initially, there is a Robot at position (0, 0). Given a sequence of its moves, judge if this robot makes a circle, which means it moves back to the original place.
         * The move sequence is represented by a string. And each move is represent by a character.
         * The valid robot moves are R (Right), L (Left), U (Up) and D (down). The output should be true or false representing whether the robot makes a circle.
         */

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
