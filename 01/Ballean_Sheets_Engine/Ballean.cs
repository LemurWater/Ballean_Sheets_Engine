using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ballean_Sheets_Engine
{
    public partial class Ballean : Form
    {
        Ballean ballean = new Ballean();
        GridModifier choices = new GridModifier();
        GridModifier items = new GridModifier();
        GridModifier enemies = new GridModifier();

        public Ballean()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonChoices_Click(object sender, EventArgs e)
        {
            choices.ShowDialog();
            this.Hide();
        }
        private void buttonItems_Click(object sender, EventArgs e)
        {
            items.ShowDialog();
            this.Hide();
        }

        private void buttonEnemies_Click(object sender, EventArgs e)
        {
            enemies.ShowDialog();
            this.Hide();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
