using CodePrototype.API;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePrototype.UI_Components.Figures
{
    public class TextFigureXCommand : SimpleXCommand
    {
        private XText text=new XText();
        public TextFigureXCommand()
        {
           
        }
        public int GetTextSize()
        {
            return text.TextSize;
        }
        public Color GetTextColor()
        {
            return text.TextColor;
        }
        public string GetText()
        {
            return text.Text;
        }
        public Font GetFont()
        {
            return text.font;
        }
        public void SetTextSize(int TextSize)
        {
            text.TextSize = TextSize;
            FigureRePaint();
            Debug.WriteLine(text.TextSize);
        }
        public void SetTextColor(Color col)
        {
            text.TextColor = col;
            FigureRePaint();
            Debug.WriteLine(text.TextColor);
        }
        public void SetText(string Text)
        {
            text.Text = Text;
            FigureRePaint();
            Debug.WriteLine(text.Text);
        }
        public void SetFont(Font font)
        {
            text.font = font;
            FigureRePaint();
            Debug.WriteLine(text.font);
        }
        public void SetXText(XText text)
        {
            this.text = text;
        }
    }
}
