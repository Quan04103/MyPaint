using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.OOP
{
    internal class Circle_OOP : Shape
    {
        private int radius;

        public Circle_OOP(Point center, int radius, int border, Color borderColor, Color backgroundColor)
            : base(new Point(center.X - radius, center.Y - radius), border, borderColor, backgroundColor)
        {
            this.radius = radius;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, border);
            g.DrawEllipse(pen, location.X, location.Y, radius * 2, radius * 2);
        }

        protected override void FillShape(Graphics g, Brush brush)
        {
            g.FillEllipse(brush, location.X, location.Y, radius * 2, radius * 2);
        }
    }
}
