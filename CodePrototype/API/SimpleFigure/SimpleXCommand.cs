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
    public enum FigureType { Line, Rectangle, RRectangle, Ellipse}
    public class SimpleXCommand : ICommand
    {
        private XData data=new XData();
        public void SetFigure(Control dBaseFigure)
        {
            data.figure = dBaseFigure;
        }
        protected void FigureRePaint()
        {
            data.figure.Invalidate();
        }
        public SimpleXCommand()
        {
           
        }
        public int GetFigureWidth()
        {
            return data.Width;
        }
        public Color GetFigureColor()
        {
            return data.col;
        }
        public FigureType GetFigureType()
        {
            return data.type;
        }
        public void SetWidth(int val)
        {
            data.Width = val;
            FigureRePaint();
            Debug.WriteLine(data.Width);
        }
        public void SetColor(Color color)
        {
            data.col = color;
            FigureRePaint();
            Debug.WriteLine(data.col);
        }
        public void SetType(FigureType type)
        {
            data.type = type;
            FigureRePaint();
            Debug.WriteLine(type);
            //MessageBox.Show(""+type);
        }
        public void SetData(XData data)
        {
            this.data = data;
        }
    }
}
