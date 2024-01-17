using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.OOP
{
    internal class FillPaternRectangle : IEnumerable<Rectangle_OOP>
    {
        public LinkedList<Rectangle_OOP> rectangles;

        public FillPaternRectangle()
        {
            rectangles = new LinkedList<Rectangle_OOP>();
        }

        public FillPaternRectangle(Point sPoint, Point ePoint, int border, Color borderColor, Color backgroundColor)
        {
            rectangles = new LinkedList<Rectangle_OOP>();
        }

        public void AddPaternRectangle(Rectangle_OOP rectangle)
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
