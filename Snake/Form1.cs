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
        public SnakeGame()
        {
            InitializeComponent();
        }

        private void Snake_Load(object sender, EventArgs e)
        {

        }

        private void Snake_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Test");
            this.Text = "Points: " + ;
        }
    }
}
