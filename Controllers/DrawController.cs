using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgingTest.Models;

namespace ForgingTest.Controllers
{
    public class DrawController
    {
        BasicSword bs;


        public DrawController()
        {
            bs = new BasicSword(new Point(300, 400));
        }

        public void Redraw(Graphics g)
        {
            Point[] points = {
               new Point(20, 50),
               new Point(100, 10),
               new Point(200, 100),
               new Point(300, 50),
               new Point(400, 80)};


            Pen pen = new Pen(Color.Black);
            var points2 = bs.Points.ToArray();
            g.DrawCurve(pen, points2, 0);

        }
    }
}
