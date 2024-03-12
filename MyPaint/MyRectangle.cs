using MyPaint.Bridge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    internal class MyRectangle
    {
        public Point location;
        public int width;
        public int height;
        public int borderWidth;
        public Color borderColor;
        public Color backgroundColor;
        private RedTheme redTheme;

        public MyRectangle()
        {

        }

        public MyRectangle(RedTheme redTheme)
        {
            this.redTheme = redTheme;
        }

        public MyRectangle(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color backgroundColor)
        {
            this.backgroundColor = backgroundColor;
            location.X = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            location.Y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            width = Math.Abs(sPoint.X - ePoint.X);
            height = Math.Abs(sPoint.Y - ePoint.Y);
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
        }

        public void Draw(Graphics g )
        {
            Pen pen = new Pen(borderColor, borderWidth);
            g.DrawRectangle(pen, location.X, location.Y, width, height);
        }

        public void Fill(Graphics g)
        {
            Brush brush = new SolidBrush(backgroundColor);
            g.FillRectangle(brush, location.X, location.Y, width, height);
        }


        private void MyRectangle_Load(object sender, EventArgs e)
        {

        }
    }
}
