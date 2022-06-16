using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PongGame
{
    public class Scena
    {
        public int height { get; set; }
        public int width { get; set; }
        Palka p1;
        Palka p2;
        public Scena(int height, int width)
        {
            this.height = height;
            this.width = width;
            Point po1 = new Point(20, height / 2);
            Point po2 = new Point(2*width - 30, height / 2);
            p1 = new Palka(po1,height);
            p2 = new Palka(po2,height);
        }
        public void Draw(Graphics g)
        {
            p1.Draw(g);
            p2.Draw(g);

        }
        public void MoveP1Up()
        {
            p1.MoveUp();
        }
        public void MoveP1Down()
        {
            p1.MoveDown();
        }

        public void MoveMouse(int y)
        {
            p2.MoveMouse(y);        }
    }
}
