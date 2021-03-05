using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForgingTest.Models;

namespace ForgingTest.Controllers
{
    public class DrawController
    {
        BasicSword bs;
        Point lastMousePos;

        public DrawController()
        {
            bs = CurveRepository.bs;
        }

        public void Redraw(Graphics g)
        {
            Pen curvePaint = new Pen(Color.Black);
            var curveFill = new SolidBrush(Color.Orange);
            var points = bs.Points.Select(point => point.ToPoint()).ToArray();
            g.FillClosedCurve(curveFill, points);
            g.DrawCurve(curvePaint, points, 0.7f);
            var mouseRadius = SettingsRepository.MouseClickRadius;
            g.DrawEllipse(curvePaint, 
                lastMousePos.X-mouseRadius/ 2, lastMousePos.Y-mouseRadius/2, mouseRadius, mouseRadius);

        }

        public void DrawMouse(int x, int y)
        {
            lastMousePos = new Point(x, y);
        }
    }
}