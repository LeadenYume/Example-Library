using Library.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LibraryTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleTest1()
        {
            var triangle = new Triangle(2, 7, 7);
            Assert.AreEqual(triangle.CalculateArea(), 6.928203230275509);
            triangle = new Triangle(62, 45, 47);
            Assert.AreEqual(triangle.CalculateArea(), 1052.9957264870548);
        }

        [TestMethod]
        public void TriangleTest2()
        {
            var triangle = new Triangle(3, 3, 3);
            var rectangle = new Rectangle(2, 2);
            Assert.AreEqual(Rectangle.IsRectangle(triangle), false);
            Assert.AreEqual(Rectangle.IsRectangle(rectangle), true);
            Assert.AreEqual(Triangle.IsTriangle(triangle), true);
            Assert.AreEqual(Triangle.IsTriangle(rectangle), false);
        }

        [TestMethod]
        public void TriangleTest3()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(triangle.IsRight(), true);
            triangle = new Triangle(3, 5, 4);
            Assert.AreEqual(triangle.IsRight(), true);
            triangle = new Triangle(3, 4, 6);
            Assert.AreEqual(triangle.IsRight(), false);
        }
    }
}
