using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePrototype
{
    public partial class DMenuBar : MenuStrip
    {
        public DMenuBar()
        {
            InitializeComponent();
            PluginsButton.Click += ButtonClick;
            PropertiesButton.Click += ButtonClick;
        }
        public void ButtonClick(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;
            tsmi.Checked = !tsmi.Checked;
        }
    }
}