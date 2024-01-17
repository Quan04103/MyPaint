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
        {
            this.location = new Point(center.X - radius, center.Y - radius);
            this.radius = radius;
            this.border = border;
            this.borderColor = borderColor;
            this.backgroundColor = backgroundColor;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(borderColor, border);
            g.DrawEllipse(pen, location.X, location.Y, radius * 2, radius * 2);
        }

        public override void Fill(Graphics g)
        {
            Brush brush = new SolidBrush(backgroundColor);
            g.FillEllipse(brush, location.X, location.Y, radius * 2, radius * 2);
        }

        public override void PatternFill(Graphics g)
        {
            // Nếu bạn muốn thêm fill pattern cho hình tròn, bạn có thể triển khai tương tự như đã làm cho hình chữ nhật
            // Ví dụ sử dụng HatchBrush
            HatchBrush hatch = new HatchBrush(HatchStyle.Cross, backgroundColor);
            g.FillEllipse(hatch, location.X, location.Y, radius * 2, radius * 2);
        }
    }
}
