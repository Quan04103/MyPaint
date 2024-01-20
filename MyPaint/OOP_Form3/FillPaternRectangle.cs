using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.OOP
{
    internal class FillPatternRectangle : Rectangle_OOP
    {
        private List<Rectangle_OOP> rectangles;

        public FillPatternRectangle(Point sPoint, Point ePoint, int border, Color borderColor, Color backgroundColor)
            : base(new Point(Math.Min(sPoint.X, ePoint.X), Math.Min(sPoint.Y, ePoint.Y)), border, borderColor, backgroundColor)
        {
            rectangles = new List<Rectangle_OOP>();
            AddRectangle(sPoint, ePoint, border, borderColor, backgroundColor);
        }

        public void AddRectangle(Point sPoint, Point ePoint, int border, Color borderColor, Color backgroundColor)
        {
            rectangles.Add(new Rectangle_OOP(sPoint, ePoint, border, borderColor, backgroundColor));
        }

        public override void Draw(Graphics g)
        {
            foreach (Rectangle_OOP rectangle in rectangles)
            {
                rectangle.Draw(g);
            }
        }

        public override void Fill(Graphics g)
        {
            foreach (Rectangle_OOP rectangle in rectangles)
            {
                rectangle.Fill(g);
            }
        }

        public override void PatternFill(Graphics g)
        {
            foreach (Rectangle_OOP rectangle in rectangles)
            {
                rectangle.PatternFill(g);
            }
        }

        protected override void FillShape(Graphics g, Brush brush)
        {
            foreach (Rectangle_OOP rectangle in rectangles)
            {
                rectangle.Fill(g);
            }
        }
    }
}
