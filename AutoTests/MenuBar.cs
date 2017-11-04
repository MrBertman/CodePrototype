using TestStack.White;
using TestStack.White.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White.UIItems.WindowItems;
using UnitTests;
using System.Diagnostics;

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
            application = Application.Launch(new ProcessStartInfo(@"CodePrototype.exe")
            {
                WorkingDirectory = @"..\..\..\CodePrototype\bin\Debug\",
            });
            window = application.GetWindow("FigurePainter", InitializeOption.NoCache);
            POM.Window = window;
        }

        [TestMethod]
        public void Exist()
        {
            Assert.IsTrue(POM.MainMenu.FileMenu.Enabled);
        }

        [TestMethod]
        public void Click()
        {
            POM.MainMenu.FileMenu.Click();
            Assert.IsTrue(true);
        }

        [TestCleanup]
        public void TestClean()
        {
            application.Close();    
        }
    }
}
