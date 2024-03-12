using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.State
{
    internal class SolidState : State
    {
        public Point Location { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int BorderWidth { get; set; }
        public Color BorderColor { get; set; }
        public Color BackgroundColor { get; set; }
        public override void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Blue);
            g.FillRectangle(brush, _rect.location.X, _rect.location.Y, _rect.width, _rect.height);
        }
    }
}
