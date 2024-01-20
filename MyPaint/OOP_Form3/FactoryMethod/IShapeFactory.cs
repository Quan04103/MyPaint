using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.FactoryMethod
{
    internal interface IShapeFactory
    {
        Shape CreateShape(Point startPoint, Point endPoint, int border, Color borderColor, Color backgroundColor);
    }
}
