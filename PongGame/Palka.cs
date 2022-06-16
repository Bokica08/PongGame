using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    public class Palka
    {
        public Color Color { get; set; }= Color.Black;
        public Point Location { get; set; }
        public static int Width { get; set; } = 10;
        public static int Height { get; set; } = 30;
        public Palka(Point p)
        {
            Location = p;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, Location.X, Location.Y, Width, Height);
            b.Dispose();
        }
        public void MoveUp()
        {
            Location=new Point(Location.X, Location.Y+5);
        }
        public void MoveDown()
        {
            Location = new Point(Location.X, Location.Y - 5);
        }

    }
}
