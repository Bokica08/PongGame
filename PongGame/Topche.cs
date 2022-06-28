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
        public bool IsStarted { get; set; }
        public double Angle { get; set; }

        private int velocityX = 10;
        private int velocityY=10;
        public int formWidth { get; set; }
        public int formHeight { get; set; }
        public int Velocity { get; }
        public bool oddalecena { get; set; }
        public Topche(Point location,int width, int formHeight)
        {
            Location = location;
            Color = Color.Black;
            IsStarted = false;
            formWidth = width;
            this.formHeight = formHeight;
            oddalecena = false;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Location.X-Radius, Location.Y-Radius, Radius * 2, Radius * 2);
            b.Dispose();
        }
        public void Move(bool direction)
        {
          if(Location.X<0 || Location.X>2*formWidth)
            {
                Location = new Point(2 * formWidth / 2, formHeight / 2 + 30);
                IsStarted = false;
            }
          if(Location.Y<0 || Location.Y>1.33*formHeight)
            {
                velocityY = -velocityY;
            }
         
            {
                if (IsStarted) {
                    double dx = velocityX * 1.5;
                    Location = new Point(Location.X + (int)dx, Location.Y+velocityY);

                }
                else
                {
                    Location = new Point(Location.X + velocityX, Location.Y);
                }

            }
        }
        public bool isHit(Point p)
        {
            double d = Math.Sqrt(Math.Pow(p.X - Location.X, 2) + Math.Pow(p.Y - Location.Y, 2));
            if(d<50)
            {
                if (!oddalecena) { 
                velocityX = -velocityX;
                oddalecena = true;
                }
                return true;
            }
            if(d>50)
            {
                oddalecena = false;
            }

            return false;
        }

    }
}
