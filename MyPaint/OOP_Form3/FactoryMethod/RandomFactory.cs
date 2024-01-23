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
    internal class RandomFactory : ICreateFact
    {

        public RandomFactory()
        {
        }
        public Shape CreateShape(Point startPoint, Point endPoint, int border, Color borderColor, Color backgroundColor)
        {
            Random random = new Random();

            // Sinh ra một số ngẫu nhiên từ 0 đến 1 để chọn loại hình
            int shapeType = random.Next(6);

            // Sinh ra một số ngẫu nhiên từ 0 đến 100 để chọn màu sắc
            int colorIndex = random.Next(100);

            // Tạo một mảng các màu sắc có sẵn
            Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Pink, Color.Purple, Color.Orange, Color.Brown, Color.Black, Color.White };

            // Chọn một màu sắc ngẫu nhiên từ mảng
            Color color = colors[colorIndex % colors.Length];

            if (shapeType == 0)
            {
                return new FillRectangle_OOP(startPoint, endPoint, border, borderColor, color);
            }
            if (shapeType == 1)
            {
                return new FillPatternRectangle(startPoint, endPoint, border, borderColor, color);
            }
            if (shapeType == 2)
            {
                return new Rectangle_OOP(startPoint, endPoint, border, borderColor, color);
            }
            if (shapeType == 3)
            {
                return new FillCircle_OOP(startPoint, endPoint, border, borderColor, color);
            }
            if (shapeType == 4)
            {
                return new FillPatternCircle(startPoint, endPoint, border, borderColor, color);
            }
            if (shapeType == 5)
            {
                return new Circle_OOP(startPoint, endPoint, border, borderColor, color);
            }
            else
            {
                return null;
            }
        }
    }
}
