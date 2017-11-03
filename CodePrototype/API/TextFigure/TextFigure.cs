using CodePrototype.UI_Components.Figures;
using CodePrototype.UI_Components.PropertiesWindows;
using CodePrototype.UI_Components.ToolBars;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePrototype.API
{
    public class TextFigure : IFigure
    {
        private XText text = new XText();
        private TextFigureXCommand command =new TextFigureXCommand();
        public TextFigure()
        {
            command.SetXText(text);
        }
        public ICommand GetCommand()
        {
            return command;
        }
        public Control GetFigure(Point location, int Width, int Height)
        {
            DTextFigure dsf = new DTextFigure();
            dsf.Location = location;
            dsf.Width = Width;
            dsf.Height = Height;
            return dsf;
        }
        public Control GetProperties(Point location, ICommand command)
        {
            TextFigureProperties tfp = new TextFigureProperties();
            tfp.Location = location;
            tfp.SetCommand(command as TextFigureXCommand);
            return tfp;
        }
        public Control GetToolBar(Point location, ICommand command)
        {
            DToolBarTextFigure dtf = new DToolBarTextFigure();
            dtf.Location = location;
            dtf.command = command as TextFigureXCommand;
            return dtf;
        }
    }
}
