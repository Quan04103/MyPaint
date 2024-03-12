using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Bridge
{
    internal class BlueTheme : ITheme
    {
        public Color GetBrushColor()
        {
            return Color.Blue;
        }

        public Color GetPenColor()
        {
            return Color.Blue;
        }
    }
}
