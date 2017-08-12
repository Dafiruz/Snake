using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Game
    {
        private int points;

        Game()
        {
            points = 0;
        }

        public int getPoints()
        {
            return points;
        }

        public void incrementPoints(int value)
        {
            points += value;
        }
    }
}
