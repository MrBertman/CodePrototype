using CodePrototype.API;
using CodePrototype.UI_Components.ToolBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePrototype
{
    public partial class FigurePainter : Form
    {
        PluginManager pmanager;
        public FigurePainter()
        {
            InitializeComponent();
            pmanager = new PluginManager(Controls);
            dElements1.pmanager = pmanager;
            dDraw1.pmanager = pmanager;
        }
    }
}
