﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovePicture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Up_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y > 0)
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X > 0)
                pictureBox1.Location = new Point(pictureBox1.Location.X -5, pictureBox1.Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y - 5);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y + 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y + 5);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y - 5);
        }

        private void pictureBox1_Click(object sender, EventArgs e)

        {

            pictureBox1.Location = new Point(pictureBox1.Location.X - 5, pictureBox1.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        
            
            {
                
            }

        private async void button5_Click(object sender, EventArgs e)

        {
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 30 );
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 30);
            await Task.Delay(500);
        }

        private async void button6_Click(object sender, EventArgs e)
  

        {
            
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 30, pictureBox1.Location.Y);
                await Task.Delay(500);
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 30);
                await Task.Delay(500);
                pictureBox1.Location = new Point(pictureBox1.Location.X + 30, pictureBox1.Location.Y);
                await Task.Delay(500);
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 30);
                await Task.Delay(500);
            }

            
        }

        private async void button7_Click(object sender, EventArgs e)
        {
             
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 30, pictureBox1.Location.Y- 30);
                await Task.Delay(500);
                pictureBox1.Location = new Point(pictureBox1.Location.X + 30, pictureBox1.Location.Y + 30);
                await Task.Delay(500);
                pictureBox1.Location = new Point(pictureBox1.Location.X - 30, pictureBox1.Location.Y);
                await Task.Delay(500);
                pictureBox1.Location = new Point(pictureBox1.Location.X + 30, pictureBox1.Location.Y - 30);
                await Task.Delay(500);
            }
        }

        private async void button8_Click(object sender, EventArgs e)


        {
            while (pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 3, pictureBox1.Location.Y);
                await Task.Delay(5);
            }
        }
    }
}
