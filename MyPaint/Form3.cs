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
        public Form3()
        {
            InitializeComponent();
            _graphic = mainPanel.CreateGraphics();
            _aPoint = new Point(-1, -1);
            _sPoint = new Point(-1, -1);
            _moving = false;
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
                FillRectangle_OOP fillRectangle = new FillRectangle_OOP(_sPoint, e.Location, penWidth, penColor, bgColor);
                FillPatternRectangle fillPatternRectangle = new FillPatternRectangle(_sPoint, e.Location, penWidth, penColor, bgColor);
                if (ColorFillButton.Checked)
                {
                    fillRectangle.Fill(_graphic);
                }
                if (ColorPatternFill.Checked)
                {
                    fillPatternRectangle.PatternFill(_graphic);
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
                FillCircle_OOP fillCircle = new FillCircle_OOP(_sPoint, radius, penWidth, penColor, bgColor);
                FillPatternCircle fillPaternCircle = new FillPatternCircle(_sPoint, radius, penWidth, penColor, bgColor);
                if (ColorFillButton.Checked)
                {
                    fillCircle.Fill(_graphic);
                }

                if (ColorPatternFill.Checked)
                {
                    fillPaternCircle.PatternFill(_graphic);
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
                FillRectangle_OOP fillRectangle = new FillRectangle_OOP(_sPoint, e.Location, penWidth, penColor, bgColor);
                FillPatternRectangle fillPatternRectangle = new FillPatternRectangle(_sPoint, e.Location, penWidth, penColor, bgColor);
                if (ColorFillButton.Checked)
                    _shapes.AddLast(fillRectangle);
                if (ColorPatternFill.Checked)
                    _shapes.AddLast(fillPatternRectangle);
                _shapes.AddLast(rect);
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
                FillCircle_OOP fillCircle = new FillCircle_OOP(_sPoint, radius, penWidth, penColor, bgColor);
                FillPatternCircle fillPaternCircle = new FillPatternCircle(_sPoint, radius, penWidth, penColor, bgColor);
                if (ColorFillButton.Checked)
                    _shapes.AddLast(fillCircle);
                if (ColorPatternFill.Checked)
                    _shapes.AddLast(fillPaternCircle);
                _shapes.AddLast(circle);
                _sPoint.X = -1;
                _sPoint.Y = -1;
                _moving = false;
            }
        }


        private void RefreshPanel()
        {
            _graphic.Clear(Color.White);

            foreach (Shape shape in _shapes)
            {
                if (shape is FillRectangle_OOP fillRectangle)
                {
                    fillRectangle.Fill(_graphic);
                }
                if (shape is FillPatternRectangle patternRectangle)
                {
                    patternRectangle.PatternFill(_graphic);
                }
                if (shape is FillCircle_OOP fillCircle)
                {
                    fillCircle.Fill(_graphic);
                }
                if (shape is FillPatternCircle fillPatternCircle)
                {
                    fillPatternCircle.PatternFill(_graphic);
                }
                shape.Draw(_graphic);

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
