using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodePrototype.UI_Components.PropertiesWindows;
using CodePrototype.UI_Components.Figures;

namespace CodePrototype.UI_Components
{
    public partial class DFigureType : UserControl
    {
        public SimpleXCommand command;
        public DFigureType()
        {
            InitializeComponent();
        }      
        private void LineButton_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            switch (bt.Text)
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
    }
}
