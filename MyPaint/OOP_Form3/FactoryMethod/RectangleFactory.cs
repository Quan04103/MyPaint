using MyPaint.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.OOP_Form3.FactoryMethod
{
    internal class RectangleFactory : IShapeFactory
    {
        public MyPaint.Shape CreateShape(Point startPoint, Point endPoint, int border, Color borderColor, Color backgroundColor)
        {
            return new Rectangle_OOP(startPoint, endPoint, border, borderColor, backgroundColor);
        }
    }
}
