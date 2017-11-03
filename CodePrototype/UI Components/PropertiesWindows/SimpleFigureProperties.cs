using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodePrototype.UI_Components.Figures;

namespace CodePrototype.UI_Components.PropertiesWindows
{
    public partial class SimpleFigureProperties : UserControl
    {
        public SimpleXCommand command;
        public SimpleFigureProperties()
        {
            InitializeComponent();
        }
        public void SetCommand(SimpleXCommand command)
        {
            this.command = command;
            dFigureType1.command = command;
            dFigureWidthColor1.command = command;
        }
    }
}
