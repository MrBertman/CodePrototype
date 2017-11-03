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

namespace CodePrototype.UI_Components
{
    public partial class DFigureWidthColor : UserControl
    {
        public SimpleXCommand command;
        public DFigureWidthColor()
        {
            InitializeComponent();
        }

        private void FigureColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    command.SetColor(cd.Color);
                }
            }
        }

        private void FigureWidthTrackBar_Scroll(object sender, EventArgs e)
        {
            command.SetWidth((sender as TrackBar).Value);
        }
    }
}
