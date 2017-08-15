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

        public SnakeGame()
        {
            InitializeComponent();
        }

        private void Snake_Load(object sender, EventArgs e)
        {

        }

        private void Snake_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            snake.draw(paper);
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            this.Text = "Points: " + snake.GetX();
            snake.moveRight();
            this.Invalidate();
        }
    }
}
