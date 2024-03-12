using MyPaint.OOP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Bridge
{
    internal abstract class MyShape 
    {
        protected ITheme _theme;
        protected Rectangle _rect;

        private Circle_OOP Circle;
        private Rectangle rec;
        private ITheme theme;

        protected MyShape(Rectangle rec, ITheme theme)
        {
            this.rec = rec;
            this.theme = theme;
        }

        public abstract void Draw(Graphics g);
    }
}
