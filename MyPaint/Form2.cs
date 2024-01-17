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
        private LinkedList<MyRectangle> _noBgRectangles;
        private LinkedList<MyRectangle> _bgRectangles;
        public Form2()
        {
            InitializeComponent();
            _graphic = mainPanel.CreateGraphics();
            _aPoint = new Point(-1, -1);
            _sPoint = new Point(-1, -1);
            _moving = false;
            _noBgRectangles = new LinkedList<MyRectangle>();
            _bgRectangles = new LinkedList<MyRectangle>();
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
            int penWidth = (int)inpPenWidth.Value;
            Color penColor = cdPenColor.Color;
            Color bgColor = cdColorBg.Color;
            MyRectangle rect = new MyRectangle(_sPoint, e.Location, penWidth, penColor, bgColor);
            if (checkBoxColor.Checked)
            {
                rect.Fill(_graphic);
            }
            rect.Draw(_graphic);
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            int penWidth = (int)inpPenWidth.Value;
            Color penColor = cdPenColor.Color;
            Color bgColor = cdColorBg.Color;
            MyRectangle rect = new MyRectangle(_sPoint, e.Location, penWidth, penColor, bgColor);
            if (checkBoxColor.Checked)
            {
                _bgRectangles.AddLast(rect);
            }
            _noBgRectangles.AddLast(rect);
            _sPoint.X = -1;
            _sPoint.Y = -1;
            _moving = false;
        }

        private void RefreshPanel()
        {
            _graphic.Clear(Color.White);
            foreach (MyRectangle rect in _noBgRectangles)
            {
                 rect.Draw(_graphic);
            }
            foreach (MyRectangle rect in _bgRectangles)
            {
                 rect.Draw(_graphic);
                 rect.Fill(_graphic);
            }
        }

        private void btnColor_Click_1(object sender, EventArgs e)
        {
            if (cdPenColor.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = cdPenColor.Color;
            }
        }

        private void btnColorBg_Click(object sender, EventArgs e)
        {
            if (cdColorBg.ShowDialog() == DialogResult.OK)
            {
                btnColorBg.BackColor = cdColorBg.Color;
            }
        }

        private void checkBoxColor_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
