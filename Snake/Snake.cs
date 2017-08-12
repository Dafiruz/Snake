using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    public class Snake
    {
        public Rectangle[] snake;
        private SolidBrush brush;
        private int x, y, width, height;

        public Snake()
        {
            snake = new Rectangle[3];
            brush = new SolidBrush(Color.Gray);

            x = 20;
            y = 0;
            width = 10;
            height = 10;

            for (int i = 0; i < snake.Length; i++)
            {
                snake[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }

        public void draw(Graphics paper)
        {
            foreach(Rectangle rec in snake)
            {
                paper.FillRectangle(brush, rec);
            }
        }
    }
}
