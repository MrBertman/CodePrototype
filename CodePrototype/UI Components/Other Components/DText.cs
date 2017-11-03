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
    public partial class DText : UserControl
    {
        public TextFigureXCommand command;
        public DText()
        {
            InitializeComponent();
        }

        private void TextInput_Enter(object sender, EventArgs e)
        {
            TextInput.Text = "";
        }

        private void TextInput_Leave(object sender, EventArgs e)
        {
            command.SetText(TextInput.Text);
        }

        private void TextColorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    command.SetTextColor(cd.Color);
                }
            }
        }

        private void FontSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            command.SetTextSize((sender as TrackBar).Value);
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                command.SetFont(fd.Font);
            }
        }
    }
}
