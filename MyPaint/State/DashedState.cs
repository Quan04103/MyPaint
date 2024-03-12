using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.State
{
    internal class DashedState : State
    {
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(_rect.borderColor, _rect.borderWidth);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g.DrawRectangle(pen, _rect.location.X, _rect.location.Y, _rect.width, _rect.height);
        }
    }
}
