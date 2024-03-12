using MyPaint.Bridge;
using MyPaint.State;
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
        private LinkedList<MyRectangleState> listRect;
        private MyRectangleState rectDefault;
        private MyRectangleState contextSolid;
        private MyRectangleState contextDotted;
        private MyRectangleState contextDashed;
        public Form2()
        {
            InitializeComponent();
            _graphic = mainPanel.CreateGraphics();
            _aPoint = new Point(-1, -1);
            _sPoint = new Point(-1, -1);
            _moving = false;
            listRect = new LinkedList<MyRectangleState>();
            rectDefault = new MyRectangleState(new Point(50, 50), new Point(150, 150), 2, Color.Black, Color.White);
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
            if (SolidBtn.Checked)
            {
                rectDefault.TransitionTo(new SolidState());
                rectDefault.Draw(_graphic);
            }
            if (DottedBtn.Checked)
            {
                rectDefault.TransitionTo(new DottedState());
                rectDefault.Draw(_graphic);
            }
            if (DashedBtn.Checked)
            {
                rectDefault.TransitionTo(new DashedState());
                rectDefault.Draw(_graphic);
            }
        }

        private void mainPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (SolidBtn.Checked)
            {
                listRect.AddLast(rectDefault);
            }
            if (DottedBtn.Checked)
            {

                listRect.AddLast(rectDefault);
            }
            _sPoint.X = -1;
            _sPoint.Y = -1;
            _moving = false;
        }

        private void RefreshPanel()
        {
            _graphic.Clear(Color.White);
            foreach (MyRectangleState rect in listRect)
            {
                 rect.Draw(_graphic);
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

        private void DashedBtn_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
