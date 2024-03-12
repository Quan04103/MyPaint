using MyPaint.Strategy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        private Graphics _graphic;
        private Pen _pen;
        private Point _aPoint;
        private Point _sPoint;
        private bool _moving;
        private LinkedList<Rectangle> _rectangles;
        IStrategy strR;
        MyShape context;

        public Form1()
        {
            InitializeComponent();
            _graphic = mainPanel.CreateGraphics();
            _pen = new Pen(Color.Black, 1);
            _aPoint = new Point(-1, -1);
            _sPoint = new Point(-1, -1);
            _moving = false;
            _rectangles = new LinkedList<Rectangle>();
            strR = new MyRectangleS();


        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _sPoint.X = e.X;
            _sPoint.Y = e.Y;
            _moving = true;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_moving || (_sPoint == _aPoint))
            {
                return;
            }
            RefreshPanel();
            Rectangle rect = GetRectangle(_sPoint, e.Location);
            if (radioButton2.Checked)
            {
                context.setStrategy(strR); 
                context.DoDraw(_graphic);
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Rectangle rect = GetRectangle(_sPoint, e.Location);
            _rectangles.AddLast(rect);
            _sPoint.X = -1;
            _sPoint.Y = -1;
            _moving = false;
        }

        private void RefreshPanel()
        {
            _graphic.Clear(Color.White);
            foreach (Rectangle rect in _rectangles)
            {
                _graphic.DrawRectangle(_pen, rect);
            }
        }
        private Rectangle GetRectangle(Point sPoint, Point ePoint)
        {
            int x = sPoint.X < ePoint.X ? sPoint.X : ePoint.X;
            int y = sPoint.Y < ePoint.Y ? sPoint.Y : ePoint.Y;
            int w = Math.Abs(sPoint.X - ePoint.X);
            int h = Math.Abs(sPoint.Y - ePoint.Y);
            return new Rectangle(x, y, w, h);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
