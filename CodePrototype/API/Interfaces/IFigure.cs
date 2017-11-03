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
    public interface IFigure
    {
        ICommand GetCommand();
        Control GetToolBar(Point location, ICommand command);
        Control GetProperties(Point location, ICommand command);
        Control GetFigure(Point location, int Width, int Height);
    }
}
