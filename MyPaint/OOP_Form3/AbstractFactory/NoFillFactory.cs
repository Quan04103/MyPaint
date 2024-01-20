using MyPaint.OOP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.OOP_Form3.AbstractFactory
{
    internal class NoFillFactory : IShapeAbstractFactory
    {
        public Rectangle_OOP CreateRectangle(Point startPoint, Point endPoint, int border, Color borderColor, Color backgroundColor)
        {
            return new Rectangle_OOP(startPoint, endPoint, border, borderColor, backgroundColor);
        }

        public Circle_OOP CreateCircle(Point startPoint, Point endPoint, int border, Color borderColor, Color backgroundColor)
        {
            return new Circle_OOP(startPoint, endPoint, border, borderColor, backgroundColor);
        }
    }
}
