using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodePrototype.UI_Components.Figures;
using CodePrototype.API;
using System.Drawing;

namespace UnitTests
{
    [TestClass]
    public class SimpleFigureTests
    {
        [DataTestMethod]
        [DataRow(1)]
        [DataRow(10)]
        [DataRow(25)]
        public void TestWidthSetGet(int width)
        {
            int expected = width;
            SimpleFigure figure=new SimpleFigure();
            (figure.GetCommand() as SimpleXCommand).SetWidth(width);
            int actual = (figure.GetCommand() as SimpleXCommand).GetFigureWidth();
            Assert.AreEqual(expected, actual);
        }
        /*[DataTestMethod]
        [DataRow(Color.Black)]
        [DataRow(Color.Red)]
        [DataRow(Color.Yellow)]
        public void TestColorSetGet(Color col)
        {
            Color expected = col;
            SimpleFigure figure = new SimpleFigure();
            (figure.GetCommand() as SimpleXCommand).SetColor(col);
            Color actual = (figure.GetCommand() as SimpleXCommand).GetFigureColor();
            Assert.AreEqual(expected, actual);
        }
        */
    }
}
