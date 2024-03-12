using MyPaint.Bridge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Strategy
{
    internal class MyRectangleS : IStrategy
    {
        public Point location;
        public int width;
        public int height;
        public int borderWidth;
        public Color borderColor;
        public Color backgroundColor;
        public MyRectangleS()
        {
        }
        public MyRectangleS(Point sPoint, Point ePoint, int borderWidth)
        {
            location.X = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            location.Y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            width = Math.Abs(sPoint.X - ePoint.X);
            height = Math.Abs(sPoint.Y - ePoint.Y);
            this.borderWidth = borderWidth;
        }
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 1);
            g.DrawRectangle(pen, location.X, location.Y, width, height);
        }
    }
}