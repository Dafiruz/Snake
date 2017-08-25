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
        
        public bool gameOver(int x, int y, Snake snake)
        {
            if (x == 0 || y == 0 || x == 576 || y == 552)
            {
                return true;
            }

            //check every part of the snake to see if the head is in contact with the body
            for (int i = 1; i < snake.getSize(); i++)
            {
                if (x == snake.snake[i].X && y == snake.snake[i].Y)
                {
                    return true;
                }
            }
            return false;
        }

        public bool gameWin()
        {
            if (getPoints() >= 500)
            {
                return true;
            }
            return false;
        }
    }
}
