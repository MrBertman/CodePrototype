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
using CodePrototype.UI_Components.Figures;

namespace CodePrototype.UI_Components
{
    public partial class DDraw : PictureBox
    {
        public PluginManager pmanager;
        public DDraw()
        {
            InitializeComponent();
        }

        private void DDraw_Click(object sender, EventArgs e)
        {
            object figureInstance = Activator.CreateInstance(pmanager.figureType);
            IFigure figure = figureInstance as IFigure;
            if (figure.GetType() == typeof(EmptyFigure))
                return;
            MouseEventArgs mea = (MouseEventArgs)(e);
            Controls.Add(figure.GetFigure(mea.Location, 100, 100));
        }
        public void SendLinks(IFigure figure)
        {
            pmanager.TypeChanged(figure);
        }
    }
}
