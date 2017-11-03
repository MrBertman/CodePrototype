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

namespace CodePrototype.UI_Components
{
    public partial class DElements : UserControl
    {
        public PluginManager pmanager = new PluginManager();
        public DElements()
        {
            InitializeComponent();
            SimpleFigureButtton.Click += click;
            FigureWithTextButton.Click += click;
            FigureWithImageButton.Click += click;
        }
        private IFigure GetButton(string name)
        {
            IFigure figure=new SimpleFigure();
            switch(name)
            {
                case "SimpleFigureButtton":
                    figure = new SimpleFigure();
                    break;
                case "FigureWithTextButton":
                    figure = new TextFigure();
                    break;
                default:
                    break;
            }
            return figure;
        }
        private void click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            pmanager.TypeChanged(GetButton(bt.Name));
        }
    }
}
