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
        public Palka p1 { get; set; }
        public Palka p2 { get; set; }
        public Topche t { get; set; }
        public Scena(int height, int width, string p1Name, string p2Name)
        {
            this.height = height;
            this.width = width;
            Point po1 = new Point(20, 180);
            Point po2 = new Point(740, 180);
            Point p = new Point(400, 180);
            p1 = new Palka(po1, height, p1Name);
            p2 = new Palka(po2, height, p2Name);
            t = new Topche(p, 2 * width, height);
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

        public void MoveP2Up()
        {
            p2.MoveUp();
        }

        public void MoveP2Down()
        {
            p2.MoveDown();
        }
        public void TopceMove()
        {
            t.Move();
            if (t.Location.X < 0)
            {
                p1.Points++;
            }
            if (t.Location.X > 790)
            {
                p2.Points++;
            }


        }
        public void isHit()
        {
            if (t.isHit(p1.Location) || t.isHit(p2.Location))
            {
                t.IsStarted = true;

            }
            else
            {
                //?
            }
        }
    }
}
