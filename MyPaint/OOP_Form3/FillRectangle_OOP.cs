using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    internal class FillRectangle_OOP : IEnumerable<Rectangle_OOP>
    {
        public LinkedList<Rectangle_OOP> rectangles;

        public FillRectangle_OOP()
        {
            rectangles = new LinkedList<Rectangle_OOP>();
        }

        public FillRectangle_OOP(Point sPoint, Point ePoint, int border, Color borderColor, Color backgroundColor)
        {
            rectangles = new LinkedList<Rectangle_OOP>();
        }

        public void AddRectangle(Rectangle_OOP rectangle)
        {
            rectangles.AddLast(rectangle);
        }
        public IEnumerator<Rectangle_OOP> GetEnumerator()
        {
            return rectangles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
