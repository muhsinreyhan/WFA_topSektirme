using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_topSektirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pictureBox1.Left -= 30;
                    break;

                case Keys.Right:
                    pictureBox1.Left += 30;
                    break;

                case Keys.Up:
                    pictureBox1.Top -= 30;
                    break;
                case Keys.Down:
                    pictureBox1.Top += 30;
                    break;

                case Keys.D:
                    timer1.Start();
                    break;
                case Keys.S:
                    timer2.Start();
                    break;

                case Keys.E:
                    timer1.Stop();
                    break;

                case Keys.W:
                    timer2.Stop();
                    break;
            }
        }

        int hizYatay = 30;
        int hizDikey = 30;

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += hizYatay;
            if (pictureBox1.Right >= this.Width)
            {
                hizYatay -= 30;
            }
            else if (pictureBox1.Left <= 0)
            {
                hizYatay = 30;
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += hizYatay;
            if (pictureBox1.Bottom >= this.Height)
            {
                hizDikey -= 30;
            }
            else if (pictureBox1.Top <= 0)
            {
                hizDikey = 30;
            }
        }
    }
}

