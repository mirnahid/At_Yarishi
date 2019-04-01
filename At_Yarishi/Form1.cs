using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Yarishi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            HorseStatus(true);
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HorseStatus(false);
        }
        void HorseStatus(bool status,PictureBox horse)
        {
            pictureBox1.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = status;
            horse.Enabled = true;
        }
        void HorseStatus(bool status)
        {
            pictureBox1.Enabled = pictureBox2.Enabled = pictureBox3.Enabled = pictureBox4.Enabled = pictureBox5.Enabled = status;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            pictureBox1.Left += rnd.Next(1, 5);
            pictureBox2.Left += rnd.Next(1, 5);
            pictureBox3.Left += rnd.Next(1, 5);
            pictureBox4.Left += rnd.Next(1, 5);
            pictureBox5.Left += rnd.Next(1, 5);

            WhoWin(pictureBox1);
            WhoWin(pictureBox2);
            WhoWin(pictureBox3);
            WhoWin(pictureBox4);
            WhoWin(pictureBox5);
            
        }
        void WhoWin(PictureBox winner)
        {
            if (winner.Right - 10 >= label1.Left)
            {
                timer1.Stop();
                HorseStatus(false, winner);
                MessageBox.Show(winner.Name);
            }
        }
    }
}
