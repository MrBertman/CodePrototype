using CodePrototype.UI_Components.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePrototype.API
{
    public class XData
    {
        public int Width;
        public Color col;
        public FigureType type;
        public Control figure;
        public XData()
        {
            Width = 10;
            col = Color.Black;
            type = FigureType.Line;
            figure = new Control();
        }
    }
}
