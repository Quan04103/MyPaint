using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.OOP
{
    internal class FillCircle_OOP : IEnumerable<Circle_OOP>
    {
        public LinkedList<Circle_OOP> circles;

        public FillCircle_OOP()
        {
            circles = new LinkedList<Circle_OOP>();
        }

        public FillCircle_OOP(Point center, int radius, int border, Color borderColor, Color backgroundColor)
        {
            circles = new LinkedList<Circle_OOP>();
        }

        public void AddCircle(Circle_OOP circle)
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
