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

        int max_right, max_left, max_up, max_down;

        public SnakeGame()
        {
            InitializeComponent();
        }

        private void Snake_Load(object sender, EventArgs e)
        {
            max_right = this.Width - 32;
            max_left = 0;
            max_up = this.Height - 32;

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
                    snake.moveUp();
                    break;
                case Keys.A:
                case Keys.Left:
                    snake.moveLeft();
                    break;
                case Keys.S:
                case Keys.Down:
                    snake.moveDown();
                    break;
                case Keys.D:
                case Keys.Right:
                    snake.moveRight();
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
