﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgingTest.Models
{
    public class RPoint
    {
        public int X { get; set;}
        public int Y { get; set;}

        public RPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point ToPoint()
        {
            return new Point(X, Y);
        }
    }
}
