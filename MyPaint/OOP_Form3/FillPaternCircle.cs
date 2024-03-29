﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.OOP
{
    internal class FillPatternCircle : Shape
    {
        private List<Circle_OOP> circles;

        public FillPatternCircle(Point center, int radius, int border, Color borderColor, Color backgroundColor)
            : base(new Point(center.X - radius, center.Y - radius), border, borderColor, backgroundColor)
        {
            circles = new List<Circle_OOP>();
            AddCircle(center, radius, border, borderColor, backgroundColor);
        }

        public void AddCircle(Point center, int radius, int border, Color borderColor, Color backgroundColor)
        {
            circles.Add(new Circle_OOP(center, radius, border, borderColor, backgroundColor));
        }

        public override void Draw(Graphics g)
        {
            foreach (Circle_OOP circle in circles)
            {
                circle.Draw(g);
            }
        }

        public override void Fill(Graphics g)
        {
            foreach (Circle_OOP circle in circles)
            {
                circle.Fill(g);
            }
        }

        public override void PatternFill(Graphics g)
        {
            foreach (Circle_OOP circle in circles)
            {
                circle.PatternFill(g);
            }
        }

        protected override void FillShape(Graphics g, Brush brush)
        {
            foreach (Circle_OOP circle in circles)
            {
                circle.Fill(g);
            }
        }
    }
}
