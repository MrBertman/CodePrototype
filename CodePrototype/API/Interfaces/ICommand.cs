using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodePrototype.UI_Components.Figures;
using System.Windows.Forms;

namespace CodePrototype.API
{
    public interface ICommand
    {
        void SetFigure(Control dBaseFigure);
    }
}
