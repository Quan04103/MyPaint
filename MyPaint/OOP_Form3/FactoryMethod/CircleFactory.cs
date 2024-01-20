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
        private string type;
        public CircleFactory(string _type)
        {
            this.type = _type;
        }
        public Shape CreateShape(Point startPoint, Point endPoint, int border, Color borderColor, Color backgroundColor)
        {
            if (type == "fill")
            {
                return new FillCircle_OOP(startPoint, endPoint, border, borderColor, backgroundColor);
            }
            if (type == "fillpatern")
            {
                return new FillPatternCircle(startPoint, endPoint, border, borderColor, backgroundColor);
            }
            if (type == "nofill")
            {
                return new Circle_OOP(startPoint, endPoint, border, borderColor, backgroundColor);
            }
            else
            {
                return null;
            }
        }
    }
}
