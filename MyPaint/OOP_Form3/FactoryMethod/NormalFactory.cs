using MyPaint.FactoryMethod;
using MyPaint.OOP;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.OOP_Form3.FactoryMethod
{
    internal class NormalFactory : ICreateFact
    {
        private string type;
        public NormalFactory(string _type)
        { 
            this.type = _type;
        }
        public Shape CreateShape(Point startPoint, Point endPoint, int border, Color borderColor, Color backgroundColor)
        {
            if(type == "rfill")
            {
                return new FillRectangle_OOP(startPoint, endPoint, border, borderColor, backgroundColor);
            }
            if(type == "rfillpatern")
            {
                return new FillPatternRectangle(startPoint, endPoint, border, borderColor, backgroundColor);
            }
            if( type == "rnofill")
            {
                return new Rectangle_OOP(startPoint, endPoint, border, borderColor, backgroundColor);
            }
            if (type == "cfill")
            {
                return new FillCircle_OOP(startPoint, endPoint, border, borderColor, backgroundColor);
            }
            if (type == "cfillpatern")
            {
                return new FillPatternCircle(startPoint, endPoint, border, borderColor, backgroundColor);
            }
            if (type == "cnofill")
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
