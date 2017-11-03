using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodePrototype.API;
using System.Drawing.Drawing2D;

namespace CodePrototype.UI_Components.Figures
{
    public partial class DTextFigure : DEmptyFigure
    {
        public DTextFigure()
        {
            InitializeComponent();
            currentFigure = new TextFigure();
        }
        private void DrawRotatedString(Graphics gr)
        {
            TextFigureXCommand command = currentFigure.GetCommand() as TextFigureXCommand;
            SizeF sz = gr.MeasureString(command.GetText(), command.GetFont());
            SizeF measure = gr.MeasureString(command.GetText(), command.GetFont());
            float deltaX = command.GetFigureWidth() + measure.Width;
            float deltaY = command.GetFigureWidth() + measure.Height;
            PointF align = new PointF(Width / 2 - deltaX / 2, Height / 2 - deltaY / 2); ;
            gr.TranslateTransform(align.X + sz.Width / 2, align.Y + sz.Height / 2);
            gr.DrawString(command.GetText(), command.GetFont(), new SolidBrush(command.GetTextColor()), new PointF(-sz.Width / 2, -sz.Height / 2));
            gr.ResetTransform();
        }
        private void DTextFigure_Paint(object sender, PaintEventArgs e)
        {
            int width = (currentFigure.GetCommand() as SimpleXCommand).GetFigureWidth();
            Pen figurePen = new Pen((currentFigure.GetCommand() as SimpleXCommand).GetFigureColor(), width);
            Rectangle drawRect = new Rectangle(new Point(width / 2, width / 2), new Size(Width - width, Height - width));
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(figurePen, GetFigureShape(drawRect));
            DrawRotatedString(e.Graphics);
        }
    }
}
