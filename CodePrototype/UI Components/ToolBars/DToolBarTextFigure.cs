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

namespace CodePrototype.UI_Components.ToolBars
{
    public partial class DToolBarTextFigure : ToolStrip
    {
        public TextFigureXCommand command;
        public DToolBarTextFigure()
        {
            InitializeComponent();
            TextWidthSelector.SelectedIndexChanged += TextWidthChanged;
            RectangleButton.Click += TypeClick;
            LineButton.Click += TypeClick;
            RRectangleButton.Click += TypeClick;
            EllipseButton.Click += TypeClick;
            ColorButton.Click += ColorClick;
            WidthStrip.SelectedIndexChanged += WidthChanged;
            TextColorButton.Click += TextColorClick;
        }

        private void TypeClick(object sender, EventArgs e)
        {
            ToolStripButton tb = sender as ToolStripButton;
            switch (tb.Text)
            {
                case "Line":
                    command.SetType(FigureType.Line);
                    break;
                case "Rectangle":
                    command.SetType(FigureType.Rectangle);
                    break;
                case "RRectangle":
                    command.SetType(FigureType.RRectangle);
                    break;
                case "Ellipse":
                    command.SetType(FigureType.Ellipse);
                    break;
            }
        }
        private void WidthChanged(object sender, EventArgs e)
        {
            try
            {
                int newWidth = Convert.ToInt32(WidthStrip.SelectedItem);
                command.SetWidth(newWidth);
            }
            catch (Exception)
            {

            }
        }
        private void ColorClick(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    command.SetColor(cd.Color);
                }
            }
        }
        private void TextWidthChanged(object sender, EventArgs e)
        {
            try
            {
                int newWidth = Convert.ToInt32(TextWidthSelector.SelectedItem);
                command.SetTextSize(newWidth);
            }
            catch (Exception)
            {

            }
        }
        private void TextColorClick(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    command.SetTextColor(cd.Color);
                }
            }
        }
    }
}
