using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Bridge
{
    internal class GreenTheme : ITheme
    {
        public Color GetBrushColor()
        {
            return Color.Green;
        }

        public Color GetPenColor()
        {
            return Color.Green;
        }
    }
}
