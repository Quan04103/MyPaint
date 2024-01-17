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
        public int width;
        public int height;
        private Point sPoint;
        private int penWidth;
        private Color penColor;
        private Color bgColor;

        public Rectangle_OOP(Point sPoint, Point ePoint, int border, Color borderColor, Color backgroundColor)
        {
            this.backgroundColor = backgroundColor;
            location.X = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            location.Y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            width = Math.Abs(sPoint.X - ePoint.X);
            height = Math.Abs(sPoint.Y - ePoint.Y);
            this.border = border;
            this.borderColor = borderColor;
        }
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, border);
            g.DrawRectangle(pen, location.X, location.Y, width, height);
        }

        public override void Fill(Graphics g)
        {
            Brush brush = new SolidBrush(backgroundColor);
            g.FillRectangle(brush, location.X, location.Y, width, height);
        }

        public override void PatternFill(Graphics g)
        {
            HatchBrush hatch = new HatchBrush(HatchStyle.Cross, backgroundColor);
            g.FillRectangle(hatch, location.X, location.Y, width, height);
        }
    }
}
