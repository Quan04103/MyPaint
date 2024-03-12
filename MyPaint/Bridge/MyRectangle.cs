using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Bridge
{
    internal class MyRectangle : MyShape
    {

        public Point location;
        public int width;
        public int height;
        public int borderWidth;
        public Color borderColor;
        public Color backgroundColor;


        public MyRectangle(Rectangle rec,ITheme theme) : base(rec, theme)
        {
            this._theme = theme;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(_theme.GetPenColor());
            Brush brush = new SolidBrush(_theme.GetBrushColor());
            g.DrawRectangle(pen, location.X, location.Y,width, height);
            g.FillRectangle(brush, location.X, location.Y, width, height);
        }
    }
}
