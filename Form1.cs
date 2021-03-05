using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForgingTest.Controllers;
using ForgingTest.Models;

namespace ForgingTest
{
    public partial class Form1 : Form
    {
        private readonly DrawController drawControlller;
        private readonly CurveController curveController;

        const int mouseRadius = 30;

        public Form1()
        {

            drawControlller = new DrawController();
            curveController = new CurveController();
            InitializeComponent();

            //Устранение мерцания
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);
            UpdateStyles();
            Width = 800;
            Height = 600;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawControlller.Redraw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
            Update();
            Refresh();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            curveController.Smash(x, y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            drawControlller.DrawMouse(e.X, e.Y);
        }
    }
}
