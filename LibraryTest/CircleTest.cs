using Library.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibraryTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleTest1()
        {
            var circle = new Circle(3);
            Assert.AreEqual(circle.CalculateArea(), 28.274333882308138);
            circle = new Circle(Math.PI);
            Assert.AreEqual(circle.CalculateArea(), Math.Pow(Math.PI, 3));
        }

        [TestMethod]
        public void CircleTest2()
        {
            var circle = new Circle(3);
            var rectangle = new Rectangle(2, 2);
            Assert.AreEqual(Rectangle.IsRectangle(circle), false);
            Assert.AreEqual(Rectangle.IsRectangle(rectangle), true);
            Assert.AreEqual(Circle.IsCircle(circle), true);
            Assert.AreEqual(Circle.IsCircle(rectangle), false);
        }
    }
}
