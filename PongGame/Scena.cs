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
        Topche t;
        public bool direction { get; set; }
        public Scena(int height, int width)
        {
            this.height = height;
            this.width = width;
            Point po1 = new Point(20, height / 2);
            Point po2 = new Point(2*width, height / 2);
            direction = false;
            Point p = new Point(2 * width / 2, height / 2+30);
            p1 = new Palka(po1,height);
            p2 = new Palka(po2,height);
                        t = new Topche(p,width,height);
        }
        public void Draw(Graphics g)
        {


            p1.Draw(g);
            p2.Draw(g);
            t.Draw(g);

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
            p2.MoveMouse(y);       
        }
        public void TopceMove()
        {
            t.Move(direction);

        }
        public void isHit()
        {
            if(t.isHit(p1.Location) || t.isHit(p2.Location))
            {
                t.IsStarted = true;

            }
            else
            {

            }
        }
    }
}
