using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Four_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool Red = false;
            Form1 game = new Form1(Red);
            game.Show();
            game.Text = "Four! Red's Turn";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool blue = true;
            Form1 game = new Form1(blue);
            game.Show();
            game.Text = "Four! Blue's Turn";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}