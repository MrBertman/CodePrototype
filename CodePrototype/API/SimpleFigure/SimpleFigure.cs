using CodePrototype.UI_Components.Figures;
using CodePrototype.UI_Components.PropertiesWindows;
using CodePrototype.UI_Components.ToolBars;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CodePrototype.API
{
    public class SimpleFigure : IFigure
    {
        private XData data=new XData();
        private SimpleXCommand command=new SimpleXCommand();
        public SimpleFigure()
        {
            command.SetData(data);
        }
        public Control GetFigure(Point location, int Width, int Height)
        {
            DSimpleFigure dsf = new DSimpleFigure();
            dsf.Location = location;
            dsf.Width = Width;
            dsf.Height = Height;
            return dsf;
        }
        public Control GetProperties(Point location,ICommand command)
        {
            SimpleFigureProperties sfp = new SimpleFigureProperties();
            sfp.Location = location;
            sfp.SetCommand(command as SimpleXCommand);
            return sfp;
        }
        public Control GetToolBar(Point location, ICommand command)
        {
            DToolBarSimpleFigure sft = new DToolBarSimpleFigure();
            sft.Location = location;
            sft.command = command as SimpleXCommand;
            return sft;
        }
        public ICommand GetCommand()
        {
            return command;
        }
    }
}
