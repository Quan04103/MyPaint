﻿using MyPaint.FactoryMethod;
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
    internal class RectangleFactory : IShapeFactory
    {
        private string type;
        public RectangleFactory(string _type)
        { 
            this.type = _type;
        }
        public Shape CreateShape(Point startPoint, Point endPoint, int border, Color borderColor, Color backgroundColor)
        {
            if(type == "fill") 
            {
                return new FillRectangle_OOP(startPoint, endPoint, border, borderColor, backgroundColor);
            }
            if(type == "fillpatern")
            {
                return new FillPatternRectangle(startPoint, endPoint, border, borderColor, backgroundColor);
            }
            if( type == "nofill")
            {
                return new Rectangle_OOP(startPoint, endPoint, border, borderColor, backgroundColor);
            }
            else
            {
                return null;
            }
        }
    }
}
