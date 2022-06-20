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

        public Form1()
        {
            scena = new Scena(ClientSize.Height, ClientSize.Width);
            InitializeComponent();
            DoubleBuffered = true;
            timer1.Interval = 50;
            timer1.Start();


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
           if(e.KeyChar=='W' || e.KeyChar=='w')
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
            int y=e.Location.Y;
            scena.MoveMouse(y);
            Invalidate();
        }

        private void dvizitopce(object sender, EventArgs e)
        {
            scena.TopceMove() ;
            scena.isHit();
            Invalidate();
        }
    }
}
