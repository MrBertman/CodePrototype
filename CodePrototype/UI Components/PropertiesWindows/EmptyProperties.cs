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

namespace CodePrototype.UI_Components.PropertiesWindows
{
    public partial class EmptyProperties : UserControl
    {
        public EmptyCommand command;
        public EmptyProperties()
        {
            InitializeComponent();
        }
        public void SetCommand(EmptyCommand command)
        {
            this.command = command;
        }
    }
}
