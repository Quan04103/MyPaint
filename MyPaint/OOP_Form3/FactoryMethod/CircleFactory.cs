using MyPaint.FactoryMethod;
using MyPaint.OOP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.OOP_Form3.FactoryMethod
{
    internal class CircleFactory : IShapeFactory
    {
        public MyPaint.Shape CreateShape(Point center, int radius, int border, Color borderColor, Color backgroundColor)
        {
            return new Circle_OOP(center, radius, border, borderColor, backgroundColor);
        }



        Shape IShapeFactory.CreateShape(Point startPoint, Point endPoint, int border, Color borderColor, Color backgroundColor)
        {
            throw new NotImplementedException();
        }
    }
}
