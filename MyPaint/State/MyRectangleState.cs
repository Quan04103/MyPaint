using MyPaint.Bridge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.State
{
    internal class MyRectangleState
    {

        public Point location;
        public int width;
        public int height;
        public int borderWidth;
        public Color borderColor;
        public Color backgroundColor;
        private RedTheme redTheme;
        private State _currentState;
        public MyRectangleState(State state)
        {
            this.TransitionTo(state);
        }

        public MyRectangleState(Point sPoint, Point ePoint, int borderWidth, Color borderColor, Color backgroundColor)
        {
            this.backgroundColor = backgroundColor;
            location.X = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            location.Y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            width = Math.Abs(sPoint.X - ePoint.X);
            height = Math.Abs(sPoint.Y - ePoint.Y);
            this.borderWidth = borderWidth;
            this.borderColor = borderColor;
        }
        public void TransitionTo(State state)
        {
            _currentState = state;
            // Đặt trạng thái cho đối tượng state
            _currentState.SetContext(this);
        }

        public void Draw(Graphics g)
        {
            _currentState.Draw(g);
        }
    }
}
