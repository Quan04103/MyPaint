using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.OOP_Form3.AbstractFactory
{
    internal class ShapeFactory
    {
        public ShapeFactory() { }
        public static IShapeAbstractFactory GetFactory(string type)
        {
            switch (type)
            {
                case "nofill":
                    return new NoFillFactory();
                case "fill":
                    return new FillFactory();
                case "fillpatern":
                    return new FillPaternFactory();
                default:
                    return null;
            }
        }
    }
}
