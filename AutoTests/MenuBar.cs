using TestStack.White;
using TestStack.White.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.WindowItems;
using UnitTests;

namespace AutoTests
{
    [TestClass]
    public class MenuBar
    {
        static Window window = null;

        [ClassInitialize]
        public static void ClassInit(TestContext t)
        {
            Application application = Application.Launch(@"C:\Users\Student\Desktop\01.11\CodePrototype\CodePrototype\bin\Debug\CodePrototype");
            window = application.GetWindow("FigurePainter", InitializeOption.NoCache);
            POM.Window = window;
        }

        [TestMethod]
        public void Click()
        {
            POM.MainMenu.FileMenu.Click();
        }
    }
}
