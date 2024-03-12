using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.State
{
    internal abstract class State
    {
        protected MyRectangleState _rect;

        public void SetContext(MyRectangleState rect)
        {
            this._rect = rect;
        }
        public abstract void Draw(Graphics g);
    }
}
