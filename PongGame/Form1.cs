using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace PongGame
{

    public partial class Form1 : Form
    {
        Scena scena;
        string p1Name = "";
        string p2Name = "";


        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            scena = new Scena(800, 400, p1Name, p2Name);
            InitializeComponent();
            DoubleBuffered = true;
            timer1.Interval = 50;
            timer1.Stop();
                
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scena.Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'W' || e.KeyChar == 'w')
            {
                scena.MoveP1Up();
                Invalidate();
            }
            if (e.KeyChar == 's' || e.KeyChar == 'S')
            {
                scena.MoveP1Down();
                Invalidate();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int y = e.Location.Y;
            scena.MoveMouse(y);
            Invalidate();
        }

        private void dvizitopce(object sender, EventArgs e)
        {
            scena.TopceMove();
            scena.isHit();
            lblPlayer1.Text = string.Format("{0}: {1}", scena.p1.Name,scena.p2.Points);
            lblPlayer2.Text = string.Format("{0}: {1}", scena.p2.Name,scena.p1.Points);
            if(scena.p1.Points==6)
            {
                pobednik(scena.p2.Name);
            }
            if(scena.p2.Points==6)
            {
                pobednik(scena.p1.Name);

            }
            Invalidate();
        }

        private void pobednik(string name)
        {
            timer1.Stop();
            DialogResult r = MessageBox.Show("Играчот " + name + " е победник! Дали сакате нова игра?", "Дали сте сигруни?", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                scena = new Scena(800, 400, p1Name, p2Name);
                DoubleBuffered = true;
                timer1.Interval = 50;
                timer1.Start();
            }
            else
            {
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.StartPosition = FormStartPosition.CenterParent;
            if (form2.ShowDialog() == DialogResult.OK)
            {
                p1Name = form2.P1Name;
                p2Name = form2.P2Name;
                scena.p1.Name = p1Name;
                scena.p2.Name = p2Name;
                lblPlayer1.Text = string.Format("{0}: 0", scena.p1.Name);
                lblPlayer2.Text = string.Format("{0}: 0", scena.p2.Name);
                form2.Close();
                timer1.Start();
            }

            else if(form2.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
