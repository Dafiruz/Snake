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
        private SolidBrush brushHead;
        private SolidBrush brushBody;
        private int x, y, width, height;

        public Snake()
        {
            snake = new Rectangle[3];
            brushBody = new SolidBrush(Color.Gray);
            brushHead = new SolidBrush(Color.White);

            x = 100;
            y = 100;
            width = 10;
            height = 10;

            for (int i = 0; i < snake.Length; i++)
            {
                snake[i] = new Rectangle(x, y, width, height);
                x -= 12;
            }
        }

        public void draw(Graphics paper)
        {
            int first = 0;
            foreach(Rectangle rec in snake)
            {
                if(first == 0)
                {
                    paper.FillRectangle(brushHead, rec);
                    first = 1;
                }
                else
                {
                    paper.FillRectangle(brushBody, rec);
                }
            }
        }

        public int GetX()
        {
            return snake[0].X;
        }

        public void moveRight()
        {
            for (int i = 0; i < snake.Length; i++)
            {
                snake[i].X += 12;
            }
        }
    }
}
