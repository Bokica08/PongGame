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
        public int formHeight { get; set; }
        public static int Width { get; set; } = 10;
        public static int Height { get; set; } = 50;
        public int Points { get; set; } = 0;
        public string Name { get; set; }
        public Palka(Point p, int height, string name)
        {
            Location = p;
            formHeight = height;
            Name = name;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, Location.X, Location.Y, Width, Height);
            b.Dispose();
        }
        public void MoveUp()
        {
            if (Location.Y > Height) { 
            Location=new Point(Location.X, Location.Y-30);
            }
            else
            {
                Location = new Point(Location.X, 30);
            }
        }
        public void MoveDown()
        {
            if (Location.Y < 350)
            {
                Location = new Point(Location.X, Location.Y + 30);
            }
            else
            {
                Location = new Point(Location.X, 350);
            }
        }

        public void MoveMouse(int y)
        {
            if (Location.Y < 350 || Location.Y>Height)
            {
                Location = new Point(Location.X, y);
            }
            if(Location.Y<50)
            {
                Location = new Point(Location.X, 50);
            }
             if(Location.Y > 350)
            {
                Location = new Point(Location.X, 350);
            }
        }

    }
}
