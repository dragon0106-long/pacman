using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            timer1.Enabled = true;
            panels = new Panel[]
            {
                panel1, panel2, panel3, panel4
            };
            pictureBoxes = new PictureBox[10]
            {
                pictureBox1,
                pictureBox2,
                pictureBox3,
                pictureBox4,
                pictureBox5,
                pictureBox6,
                pictureBox7,
                pictureBox8,
                pictureBox9,
                pictureBox10
            };
            
        }
        bool goup,godown,goright,goleft=false;
        PictureBox[] pictureBoxes;
        Panel[]panels;
        int pacmanspeed = 5;

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goup == true)
            {
                pacman.Top -= pacmanspeed;
                pacman.Image = Properties.Resources.pacmanup;
            }
            if (godown == true)
            {
                pacman.Top += pacmanspeed;
                pacman.Image = Properties.Resources.pacmandown;
            }
            if (goleft == true)
            {
                pacman.Left -= pacmanspeed;
                pacman.Image = Properties.Resources.pacmanleft;
            }
            if (goright == true)
            {
                pacman.Left += pacmanspeed;
                pacman.Image = Properties.Resources.pacman;
            }

            for(int i = 0;i < 10; i++)
            {
                if (pacman.Bounds.IntersectsWith(pictureBoxes[i].Bounds))
                {
                    pictureBoxes[i].Visible = false;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (pacman.Bounds.IntersectsWith(panels[i].Bounds))
                {
                    goup = godown = goleft = goright = false;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Up)
            //{
            //    goup = false;
            //}
            //if (e.KeyCode == Keys.Down)
            //{
            //    godown = false;
            //}
            //if (e.KeyCode == Keys.Left)
            //{
            //    goleft = false;
            //}
            //if (e.KeyCode == Keys.Right)
            //{
            //    goright = false;
            //}
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            goup = godown = goleft = goright = false;
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }
    }
}
