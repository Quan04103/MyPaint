using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
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

        public abstract void Draw(Graphics g);
        public abstract void Fill(Graphics g);
        public abstract void PatternFill(Graphics g);
    }
}
