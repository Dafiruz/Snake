using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Game
    {
        Snake snake = new Snake();
        Food food = new Food();

        private int points;

        public Game()
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
        
        public bool gameOver(int x, int y)
        {
            return true;
        }
    }
}
