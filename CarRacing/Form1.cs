using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRacing
{
    public partial class Form1 : Form
    {
        int carSpeed = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(carSpeed);
        }

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed;
            }
            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }
            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }
            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else
            {
                pictureBox4.Top += speed;
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(pictureBox7.Left > 0)
                pictureBox7.Left += -5;
            }
            if(e.KeyCode == Keys.Right)
            {
                if (pictureBox7.Left < 400 - pictureBox7.Width/2)
                    pictureBox7.Left += 5;
            }if(e.KeyCode == Keys.Up)
            {
                if (carSpeed < 15)
                    carSpeed++;
            }if(e.KeyCode == Keys.Down)
            {
                if (carSpeed > 0)
                    carSpeed--;
            }
        }
    }
}
