using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        private const int maxXY = 550;
        private int x, y, height, width;
        public Rectangle[] food;
        private SolidBrush brush;
        Random random = new Random();

        public Food()
        {
            //make sure the food will be in a coordinate the snake can reach
            do
            {
                x = random.Next(maxXY);
            } while (x % 12 != 0);
            do
            {
                y = random.Next(maxXY);
            } while (y % 12 != 0);

            height = 8;
            width = 8; 
            food = new Rectangle[1];
            brush = new SolidBrush(Color.OrangeRed);
            food[0] = new Rectangle(x, y, width, height);
        }

        public void draw(Graphics paper)
        {
            paper.FillRectangle(brush, food[0]);
        }

        public int GetY()
        {
            return food[0].Y;
        }

        public int GetX()
        {
            return food[0].X;
        }
    }
}
