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
        private const int maxXY = 590;
        private int x, y, height, width;
        private Color color;
        public Rectangle[] food;
        private SolidBrush brush;
        Random random = new Random();

        public Food()
        {
            x = random.Next(maxXY);
            y = random.Next(maxXY);
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
