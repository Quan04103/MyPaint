using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint.Bridge
{
    internal interface ITheme
    {
        Color GetPenColor();
        Color GetBrushColor();
    }
}
