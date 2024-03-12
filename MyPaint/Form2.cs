using MyPaint.Bridge;
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
    public partial class Form2 : Form
    {
        private Graphics _graphic;
        private Point _aPoint;
        public Point _sPoint;
        private bool _moving;
        private LinkedList<IStrategy> _rects;
        private LinkedList<IStrategy> _cirs;
        private IStrategy strR;
        private IStrategy strC;
        private Strategy.MyShape context;
        public Form2()
        {
            InitializeComponent();
            _graphic = mainPanel.CreateGraphics();
            _aPoint = new Point(-1, -1);
            _sPoint = new Point(-1, -1);
            _moving = false;
            _rects = new LinkedList<IStrategy>();
            _cirs = new LinkedList<IStrategy>();
            strR = new MyRectangleS();
            strC = new MyCircleS();
            context = new Strategy.MyShape();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _sPoint = e.Location;
            _moving = true;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_moving || (_sPoint == _aPoint)) { return; }
            RefreshPanel();
            if (RecBtn.Checked)
            {
                strR = new MyRectangleS(_sPoint, e.Location, 1);
                context.setStrategy(strR);
                context.DoDraw(_graphic);
            }
            if (CircleBtn.Checked)
            {
                strC = new MyCircleS(_sPoint, e.Location, 1);
                context.setStrategy(strC);
                context.DoDraw(_graphic);
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (RecBtn.Checked)
            {
                strR = new MyRectangleS(_sPoint, e.Location, 1);
                context.setStrategy(strR);
                context.DoDraw(_graphic);
                _rects.AddLast(strR);
            }
            if (CircleBtn.Checked)
            {
                strC = new MyCircleS(_sPoint, e.Location, 1);
                context.setStrategy(strC);
                context.DoDraw(_graphic);
                _cirs.AddLast(strC);
            }

            //MyRectangle rect = new MyRectangle(_sPoint, e.Location, , penColor, bgColor);
            //if (checkBoxColor.Checked)
            //{
            //    _bgRectangles.AddLast(rect);
            //}
            //_noBgRectangles.AddLast(rect);
            _sPoint.X = -1;
            _sPoint.Y = -1;
            _moving = false;
        }

        private void RefreshPanel()
        {
            _graphic.Clear(Color.White);
            foreach (IStrategy str in _rects)
            {
                 str.Draw(_graphic);
            }
            foreach (IStrategy str in _cirs)
            {
                 str.Draw(_graphic);
            }
        }
        private void checkBoxColor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
