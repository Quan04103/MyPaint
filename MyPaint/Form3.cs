using MyPaint.OOP;
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
    public partial class Form3 : Form
    {
        private Graphics _graphic;
        private Point _aPoint;
        public Point _sPoint;
        private bool _moving;
        private LinkedList<Shape> _shapes;
        private LinkedList<Rectangle_OOP> _rectangle;
        private LinkedList<Circle_OOP> _circle;
        private FillPaternRectangle _fillPaternRectangle;
        private FillRectangle_OOP _fillRectangles;
        private FillCircle_OOP _fillCircles;
        private FillPaternCircle _fillPaternCircles;
        public Form3()
        {
            InitializeComponent();
            _graphic = mainPanel.CreateGraphics();
            _aPoint = new Point(-1, -1);
            _sPoint = new Point(-1, -1);
            _moving = false;
            _rectangle = new LinkedList<Rectangle_OOP>();
            _circle = new LinkedList<Circle_OOP>();
            _fillPaternRectangle = new FillPaternRectangle();
            _fillCircles = new FillCircle_OOP();
            _fillPaternCircles = new FillPaternCircle();
            _fillRectangles = new FillRectangle_OOP();
            _shapes = new LinkedList<Shape>();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            _sPoint = e.Location;
            _moving = true;
        }

        private void mainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (RecBtn.Checked) {
                if (!_moving || (_sPoint == _aPoint)) { return; }
                RefreshPanel();
                int penWidth = (int)inpPenWidth.Value;
                Color penColor = cdPenColor.Color;
                Color bgColor = cdBgColor.Color;
                Rectangle_OOP rect = new Rectangle_OOP(_sPoint, e.Location, penWidth, penColor, bgColor);
                //if (checkBoxColor.Checked)
                //{
                //    rect.Fill(_graphic);
                //}
                if (ColorFillButton.Checked)
                {
                    rect.Fill(_graphic);
                }
                if (ColorPatternFill.Checked)
                {
                    rect.PatternFill(_graphic);
                }
                rect.Draw(_graphic);
            }
            if (CircleBtn.Checked)
            {
                if (!_moving || (_sPoint == _aPoint)) { return; }
                RefreshPanel();
                int penWidth = (int)inpPenWidth.Value;
                Color penColor = cdPenColor.Color;
                Color bgColor = cdBgColor.Color;
                int radius = (int)Math.Sqrt(Math.Pow(e.X - _sPoint.X, 2) + Math.Pow(e.Y - _sPoint.Y, 2));
                Circle_OOP circle = new Circle_OOP(_sPoint, radius, penWidth, penColor, bgColor);

                if (ColorFillButton.Checked)
                {
                    circle.Fill(_graphic);
                }

                if (ColorPatternFill.Checked)
                {
                    circle.PatternFill(_graphic);
                }

                circle.Draw(_graphic);
            }

        }
        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (RecBtn.Checked) 
            {
                int penWidth = (int)inpPenWidth.Value;
                Color penColor = cdPenColor.Color;
                Color bgColor = cdBgColor.Color;
                Rectangle_OOP rect = new Rectangle_OOP(_sPoint, e.Location, penWidth, penColor, bgColor);
                
                //if (checkBoxColor.Checked)
                //{
                //    _bgRectangles.AddLast(rect);
                //}
                if (ColorFillButton.Checked)
                {
                    _fillRectangles.AddRectangle(rect);
                }
                if (ColorPatternFill.Checked)
                {
                    _fillPaternRectangle.AddPaternRectangle(rect);
                }
                _rectangle.AddLast(rect);
                _sPoint.X = -1;
                _sPoint.Y = -1;
                _moving = false;
            }
            if (CircleBtn.Checked)
            {
                int penWidth = (int)inpPenWidth.Value;
                Color penColor = cdPenColor.Color;
                Color bgColor = cdBgColor.Color;
                int radius = (int)Math.Sqrt(Math.Pow(e.X - _sPoint.X, 2) + Math.Pow(e.Y - _sPoint.Y, 2));
                Circle_OOP circle = new Circle_OOP(_sPoint, radius, penWidth, penColor, bgColor);
                //if (checkBoxColor.Checked)
                //{
                //    _bgRectangles.AddLast(rect);
                //}
                if (ColorFillButton.Checked)
                {
                    _fillCircles.AddCircle(circle);
                }
                if (ColorPatternFill.Checked)
                {
                    _fillPaternCircles.AddPaternCircle(circle);
                }
                _circle.AddLast(circle);
                _sPoint.X = -1;
                _sPoint.Y = -1;
                _moving = false;
            }
        }


        private void RefreshPanel()
        {
            _graphic.Clear(Color.White);
            foreach (Rectangle_OOP rect in _rectangle)
            {
                rect.Draw(_graphic);
            }
            foreach (Rectangle_OOP rect in _fillRectangles)
            {
                rect.Draw(_graphic);
                rect.Fill(_graphic);
            }
            foreach (Rectangle_OOP rect in _fillPaternRectangle)
            {
                rect.Draw(_graphic);
                rect.Fill(_graphic);
                rect.PatternFill(_graphic);
            }
            foreach(Circle_OOP circle in _circle)
            {
                circle.Draw(_graphic);
            }
            foreach (Circle_OOP circle in _fillCircles)
            {
                circle.Draw(_graphic);
                circle.Fill(_graphic);
            }
            foreach (Circle_OOP circle in _fillPaternCircles)
            {
                circle.Draw(_graphic);
                circle.Fill(_graphic);
                circle.PatternFill(_graphic);
            }
        }

        private void btnWidthColor_Click(object sender, EventArgs e)
        {
            if (cdPenColor.ShowDialog() == DialogResult.OK)
            {
                btnWidthColor.BackColor = cdPenColor.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cdBgColor.ShowDialog() == DialogResult.OK)
            {
                btnBgColor.BackColor = cdBgColor.Color;
            }
        }
    }
}
