using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodePrototype.UI_Components;
using CodePrototype.API;
using System.Drawing.Drawing2D;

namespace CodePrototype.UI_Components.Figures
{
    public partial class DSimpleFigure : DEmptyFigure
    {
        public DSimpleFigure()
        {
            InitializeComponent();
            currentFigure = new SimpleFigure();
        }
        private void DSimpleFigure_Paint(object sender, PaintEventArgs e)
        {
            int width = (currentFigure.GetCommand() as SimpleXCommand).GetFigureWidth();
            Pen figurePen = new Pen((currentFigure.GetCommand() as SimpleXCommand).GetFigureColor(), width);
            Rectangle drawRect = new Rectangle(new Point(width / 2, width / 2), new Size(Width-width,Height-width));
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(figurePen, GetFigureShape(drawRect));
        }
    }
}
