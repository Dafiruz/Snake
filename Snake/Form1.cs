using System;
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
        Food food = new Food();

        string last_direction = "right";
        int max_right, max_left, max_up, max_down;

        public SnakeGame()
        {
            InitializeComponent();
        }

        private void Snake_Load(object sender, EventArgs e)
        {
            max_right = this.Width - 36;
            max_down = this.Height - 50;
            max_left = max_up = 12;
        }

        private void Snake_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            food.draw(paper);
            snake.draw(paper);
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                case Keys.Up:
                    if (last_direction != "down" && snake.GetY(0) >= max_up)
                    {
                        snake.move("up");
                        last_direction = "up";
                    }
                    break;
                case Keys.A:
                case Keys.Left:
                    if (last_direction != "right" && snake.GetX(0) >= max_left)
                    {
                        snake.move("left");
                        last_direction = "left";
                    }
                    break;
                case Keys.S:
                case Keys.Down:
                    if (last_direction != "up" && snake.GetY(0) <= max_down)
                    {
                        snake.move("down");
                        last_direction = "down";
                    }
                    break;
                case Keys.D:
                case Keys.Right:
                    if (last_direction != "left" && snake.GetX(0) <= max_right)
                    {
                        snake.move("right");
                        last_direction = "right";
                    }
                    break;
                default:
                    break;
            }
            if (snake.eat(food.GetX(), food.GetY()))
            {
                game.incrementPoints(10);
                food = new Food();
                snake.grow();
            }

            if (game.gameOver(snake.GetX(0), snake.GetY(0), snake))
            {
                MessageBox.Show("Game Over!\n\nYou got "+game.getPoints()+" points!");
                this.Close();
            }

            this.Text = "Snake | Points: " + game.getPoints();
            
            this.Invalidate();
        }
    }
}
