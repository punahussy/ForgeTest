using ForgingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgingTest.Controllers
{
    public class CurveController
    {
        public void Smash(int x, int y)
        {
            var toMove = CurveRepository.bs.Points
                .Where(point => insideMouseArea(point, x, y))
                .ToList();
            for (int point = 0; point < toMove.Count(); point++)
            {
                var toEdit = toMove[point];

                if (toEdit.X > x)
                    toEdit.X += toEdit.X - x;
                else if (toEdit.X < x)
                    toEdit.X -= x - toEdit.X;
                if (toEdit.Y > y)
                    toEdit.Y += toEdit.Y - y;
                else if (toEdit.Y < y)
                    toEdit.Y -= y - toEdit.Y;
            }
        }

        private bool insideMouseArea(RPoint point, int clickX, int clickY)
        {
            double distance = Math.Sqrt(Math.Pow(point.X - clickX, 2) + Math.Pow(point.Y - clickY, 2));
            if (distance <= SettingsRepository.MouseClickRadius)
            {
                return true;
            }
            return false;
        }
    }
}
