using CodePrototype.UI_Components;
using CodePrototype.UI_Components.PropertiesWindows;
using CodePrototype.UI_Components.ToolBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace CodePrototype.API
{
    public class PluginManager
    {
        public Type figureType;
        private ControlCollection formControls; //formControlls;
        public PluginManager()
        { }

        public PluginManager(ControlCollection contrls)
        {
           formControls = contrls;
           figureType = typeof(EmptyFigure);
        }

        public void TypeChanged(IFigure figure)
        {
            figureType = figure.GetType();
            for (int i = 0; i < formControls.Count; i++)//перебор по всем контролам
            {
                if (formControls[i].GetType().ToString().Contains("Figure") && formControls[i].GetType().ToString().Contains("ToolBar"))//ищем кастомные тулбары
                {
                    Control toolbar = figure.GetToolBar(formControls[i].Location,figure.GetCommand());
                    formControls.RemoveAt(i);
                    formControls.Add(toolbar);
                }
                if ((formControls[i].GetType().ToString().Contains("Properties")))
                {
                    Control properties = figure.GetProperties(formControls[i].Location, figure.GetCommand());
                    formControls.RemoveAt(i);
                    formControls.Add(properties);
                }
            }
        }

    }
}
