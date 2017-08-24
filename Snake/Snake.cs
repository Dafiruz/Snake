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
        private int x, y, width, height, size = 2303, remainingSize = 2300;

        public Snake()
        {
            snake = new Rectangle[size];
            brushBody = new SolidBrush(Color.Gray);
            brushHead = new SolidBrush(Color.White);

            x = 144;
            y = 144;
            width = 10;
            height = 10;

            for (int i = 0; i < snake.Length - remainingSize; i++)
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

        public int GetY(int i)
        {
            return snake[i].Y;
        }

        public int GetX(int i)
        {
            return snake[i].X;
        }

        public int getSize()
        {
            return size - remainingSize;
        }

        public void move(string direction)
        {
            //save the position of first two squares
            int old_x = snake[0].X;
            int old_y = snake[0].Y;
            int old_x2 = snake[1].X;
            int old_y2 = snake[1].Y;

            //move the head of the snake
            switch (direction)
            {
                case "right":
                    snake[0].X += 12;
                    break;
                case "left":
                    snake[0].X -= 12;
                    break;
                case "up":
                    snake[0].Y -= 12;
                    break;
                case "down":
                    snake[0].Y += 12;
                    break;
                default:
                    break;
            }

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

        public Boolean eat(int foodX, int foodY)
        {
            if (GetX(0) == foodX && GetY(0) == foodY)
            {
                return true;
            }
            return false;
        }

        public void grow()
        {
            int x = snake[size - remainingSize].X;
            int y = snake[size - remainingSize].Y;
            remainingSize--;
            snake[size - remainingSize - 1] = new Rectangle(x, y, width, height);
        }
    }
}
