﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class SnakeGame : Form
    {

        Game game = new Game();
        Graphics paper;
        Snake snake = new Snake();

        string last_direction = "right";
        int max_right, max_left, max_up, max_down;

        public SnakeGame()
        {
            InitializeComponent();
        }

        private void Snake_Load(object sender, EventArgs e)
        {
            max_right = this.Width - 32;
            max_left = 0;
            max_up = 0;
        }

        private void Snake_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            snake.draw(paper);
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            this.Text = "Points: " + snake.GetX();
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    if (last_direction != "down")
                    {
                        snake.move("up");
                        last_direction = "up";
                    }
                    break;
                case Keys.A:
                case Keys.Left:
                    if (last_direction != "right")
                    {
                        snake.move("left");
                        last_direction = "left";
                    }
                    break;
                case Keys.S:
                case Keys.Down:
                    if (last_direction != "up")
                    {
                        snake.move("down");
                        last_direction = "down";
                    }
                    break;
                case Keys.D:
                case Keys.Right:
                    if (last_direction != "left")
                    {
                        snake.move("right");
                        last_direction = "right";
                    }
                    break;
                default:
                    break;
            }

            //limit to the right
            //if (snake.GetX() < max_right)

            this.Invalidate();
        }
    }
}
