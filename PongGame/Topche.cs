using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PongGame
{
    public class Topche
    {
        public Color Color { get; set; }
        public Point Location { get; set; }
        public static int Radius { get; set; } = 5;
        private bool IsStarted = false;
        public Topche(Point location)
        {
            Location = location;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Location.X, Location.Y, Radius * 2, Radius * 2);
        }
        public void Move(bool direction)
        {

        }
    }
}
