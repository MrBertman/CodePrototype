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
        static Application application = null;
        /*
        [ClassInitialize]
        public static void ClassInit(TestContext t)
        {
            application = Application.Launch(@"C:\Users\Student\Desktop\01.11\CodePrototype\CodePrototype\bin\Debug\CodePrototype");
            window = application.GetWindow("FigurePainter", InitializeOption.NoCache);
            POM.Window = window;
        }
        */
        [TestInitialize]
        public void TestInit()
        {
            application = Application.Launch(@"C:\Users\Student\Desktop\01.11\CodePrototype\CodePrototype\bin\Debug\CodePrototype.exe");
            window = application.GetWindow("FigurePainter", InitializeOption.NoCache);
            POM.Window = window;
        }

        [TestMethod]
        public void Click()
        {
            Assert.IsTrue(POM.MainMenu.FileMenu.Enabled);
        }

        [ClassCleanup]
        public static void ClassClean()
        {
            application.Close();    
        }
    }
}
