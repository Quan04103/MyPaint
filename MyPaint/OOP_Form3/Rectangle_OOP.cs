using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    internal class Rectangle_OOP : Shape
    {
        private int width;
        private int height;

        public Rectangle_OOP(Point location, int border, Color borderColor, Color backgroundColor) : base(location, border, borderColor, backgroundColor)
        {
        }

        public Rectangle_OOP(Point sPoint, Point ePoint, int border, Color borderColor, Color backgroundColor)
            : base(new Point(Math.Min(sPoint.X, ePoint.X), Math.Min(sPoint.Y, ePoint.Y)), border, borderColor, backgroundColor)
        {
            width = Math.Abs(sPoint.X - ePoint.X);
            height = Math.Abs(sPoint.Y - ePoint.Y);
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, border);
            g.DrawRectangle(pen, location.X, location.Y, width, height);
        }

        protected override void FillShape(Graphics g, Brush brush)
        {
            g.FillRectangle(brush, location.X, location.Y, width, height);
        }
    }
}
