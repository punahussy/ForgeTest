using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgingTest.Models
{
    public class BasicSword : Curve
    {
        const int resolution = 15;
        const int relativeHeight = 300; //px
        const int relativeWidth = 40;

        public BasicSword(RPoint startPoint)
        { 
            Points = new List<RPoint>();
            Points.Add(startPoint);
            for (int leftSide = 0; leftSide < relativeHeight / resolution; leftSide++)
            {
                Points.Add(new RPoint(startPoint.X, Points.Last().Y - resolution));
            }
            for (int top = 0; top < relativeWidth / resolution; top++)
            {
                Points.Add(new RPoint(Points.Last().X + resolution, Points.Last().Y));
            }
            for (int rightSide = 0; rightSide < relativeHeight / resolution; rightSide++)
            {
                Points.Add(new RPoint(Points.Last().X, Points.Last().Y + resolution));
            }
        }
    }
}
