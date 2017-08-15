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

        public void moveLeft()
        {
            for (int i = 0; i < snake.Length; i++)
            {
                snake[i].X -= 12;
            }
        }

        public void moveUp()
        {
            for (int i = 0; i < snake.Length; i++)
            {
                snake[i].Y -= 12;
            }
        }

        public void moveDown()
        {
            //save the position of the previous square
            int old_x = snake[0].X;
            int old_y = snake[0].Y;
            int old_x2 = snake[1].X;
            int old_y2 = snake[1].Y;

            //move the head of the snake down
            snake[0].Y += 12;

            //move the rest of the body to the following position
            for (int i = 1; i < snake.Length; i++)
            {
                old_x2 = snake[i].X;
                old_y2 = snake[i].Y;
                snake[i].X = old_x;
                snake[i].Y = old_y;
                old_x = old_x2;
                old_y = old_y2;
            }
        }
    }
}
