using MyPaint.OOP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.OOP_Form3.AbstractFactory
{
    internal interface IShapeAbstractFactory
    {
        Rectangle_OOP CreateRectangle(Point startPoint, Point endPoint, int border, Color borderColor, Color backgroundColor);
        Circle_OOP CreateCircle(Point startPoint, Point endPoint, int border, Color borderColor, Color backgroundColor);
    }
}
