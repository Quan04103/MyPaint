//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace MyPaint.FactoryMethod
//{
//    internal class ShapeFactory : IShapeFactory
//    {
//        public Shape CreateShape(String type,Point sPoint, Point ePoint, int border, Color borderColor, Color backgroundColor)
//        {
//            switch (type.ToLower())
//            {
//                case "rectangle":
//                    return new Rectangle_OOP(sPoint, ePoint, border, borderColor, backgroundColor);
//                default:
//                    throw new ArgumentException("Invalid animal type");
//            }
//        }

//    }
//}
