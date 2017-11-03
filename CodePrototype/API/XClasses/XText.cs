using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrototype.API
{
    public class XText
    {
        public int TextSize;
        public Color TextColor;
        public string Text;
        public Font font;
        public XText()
        {
            TextSize = 12;
            TextColor = Color.Black;
            Text = "Example";
            font = new Font("Arial", 12);
        }
    }
}
