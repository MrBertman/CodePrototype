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
    public partial class TextFigureProperties : UserControl
    {
        private TextFigureXCommand command;
        public TextFigureProperties()
        {
            InitializeComponent();
        }
        public void SetCommand(TextFigureXCommand command)
        {
            this.command = command;
            dFigureWidthColor1.command = command;
            dFigureType1.command = command;
            dText1.command = command;
        }
    }
}
