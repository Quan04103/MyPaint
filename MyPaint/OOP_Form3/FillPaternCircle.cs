using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.OOP
{
    internal class FillPaternCircle : IEnumerable<Circle_OOP>
    {
        public LinkedList<Circle_OOP> circles;

        public FillPaternCircle()
        {
            circles = new LinkedList<Circle_OOP>();
        }

        public FillPaternCircle(Point center, int radius, int border, Color borderColor, Color backgroundColor)
        {
            circles = new LinkedList<Circle_OOP>();
            AddPaternCircle(new Circle_OOP(center, radius, border, borderColor, backgroundColor));
        }

        public void AddPaternCircle(Circle_OOP circle)
        {
            circles.AddLast(circle);
        }

        public IEnumerator<Circle_OOP> GetEnumerator()
        {
            return circles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
