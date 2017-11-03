using CodePrototype.UI_Components.Figures;
using CodePrototype.UI_Components.PropertiesWindows;
using CodePrototype.UI_Components.ToolBars;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePrototype.API
{
    public class EmptyFigure : IFigure
    {
        EmptyCommand EC = new EmptyCommand();
        public ICommand GetCommand()
        {
            return EC;
        }

        public Control GetFigure(Point location, int Width, int Height)
        {
            DEmptyFigure dsf = new DEmptyFigure();
            dsf.Location = location;
            dsf.Width = Width;
            dsf.Height = Height;
            return dsf;
        }

        public Control GetProperties(Point location, ICommand command)
        {
            EmptyProperties dp = new EmptyProperties();
            dp.Location = location;
            return dp;
        }

        public Control GetToolBar(Point location, ICommand command)
        {
            DToolBarFigure dtbf = new DToolBarFigure();
            dtbf.Location = location;
            return dtbf;
        }
    }
}
