using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.WindowItems;

namespace UnitTests
{
    public class POM
    {
        public static Window Window { get; set; }
        //public static string AppPath => @"E:\work\PainterForVladYaroslav\GIT\PainterTests\Painter\bin\Debug\Painter";
        public static string AppPath => @".CodePrototype\bin\Debug\CodePrototype"; //path relative to solution folder
        public static string WindowName => "FigurePainter";

        public static class MainMenu
        {
            public static Menu FileMenu => Window.MenuBar.MenuItemBy(SearchCriteria.ByText("File"));
        }
    }
}
