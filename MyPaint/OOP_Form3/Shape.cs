using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    internal abstract class Shape
    {
        protected Point location;
        protected int border;
        protected Color borderColor;
        protected Color backgroundColor;

        protected Shape(Point location, int border, Color borderColor, Color backgroundColor)
        {
            this.location = location;
            this.border = border;
            this.borderColor = borderColor;
            this.backgroundColor = backgroundColor;
        }

        public abstract void Draw(Graphics g);

        public virtual void Fill(Graphics g)
        {
            Brush brush = new SolidBrush(backgroundColor);
            FillShape(g, brush);
        }

        public virtual void PatternFill(Graphics g)
        {
            HatchBrush hatch = new HatchBrush(HatchStyle.Cross, backgroundColor);
            FillShape(g, hatch);
        }

        protected abstract void FillShape(Graphics g, Brush brush);
    }
}
