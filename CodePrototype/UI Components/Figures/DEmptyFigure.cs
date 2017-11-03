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
    public partial class DEmptyFigure : PictureBox
    {
        Point moving;
        protected IFigure currentFigure;
        public DEmptyFigure()
        {
            InitializeComponent();
            currentFigure = new EmptyFigure();
        }

        private void DBaseFigure_Click(object sender, EventArgs e)
        {
            (Parent as DDraw).SendLinks(currentFigure);
            (currentFigure.GetCommand() as ICommand).SetFigure(this);
        }

        private void DBaseFigure_MouseDown(object sender, MouseEventArgs e)
        {
            moving = Cursor.Position;
        }

        private void DBaseFigure_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point shift = new Point(Cursor.Position.X - moving.X, Cursor.Position.Y - moving.Y);
                this.Location = new Point(this.Location.X + shift.X, this.Location.Y + shift.Y);
                moving = Cursor.Position;
            }
        }
        protected GraphicsPath GetFigureShape(Rectangle drawClip)
        {
            GraphicsPath shape = new GraphicsPath();
            FigureType ftype = (currentFigure.GetCommand() as SimpleXCommand).GetFigureType();
            switch (ftype)
            {
                case FigureType.Rectangle: shape.AddRectangle(drawClip); break;
                case FigureType.RRectangle: shape.AddPath(GetRRectanglePath(drawClip), true); break;
                case FigureType.Ellipse: shape.AddEllipse(drawClip); break;
                case FigureType.Line: shape.AddPath(GetLinePath(), true); break;
            }
            return shape;
        }
        protected GraphicsPath GetRRectanglePath(Rectangle drawClip)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = 20;

            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(drawClip.Location, size);

            path.AddArc(arc, 180, 90);
            arc.X = drawClip.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = drawClip.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = drawClip.Left;
            path.AddArc(arc, 90, 90);
            arc.Y = drawClip.Top;
            path.CloseFigure();

            return path;
        }
        protected GraphicsPath GetLinePath()
        {
            GraphicsPath line = new GraphicsPath();

            Point topLeft = new Point(Math.Min(Location.X, Right), Math.Min(Location.Y, Bottom));

            Point startLine = new Point(Location.X - topLeft.X, Location.Y - topLeft.Y);
            Point endLine = new Point((Location.X + Size.Width) - topLeft.X, (Location.Y + Size.Height) - topLeft.Y);

            line.AddLine(startLine, endLine);

            return line;
        }
    }
}
