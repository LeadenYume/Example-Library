using Library.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTest
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void RectangleTest1()
        {
            var triangle = new Rectangle(2, 7);
            Assert.AreEqual(triangle.CalculateArea(), 14);
            triangle = new Rectangle(62, 45);
            Assert.AreEqual(triangle.CalculateArea(), 2790);
        }

        [TestMethod]
        public void RectangleTest2()
        {
            var triangle = new Triangle(3, 3, 3);
            var rectangle = new Rectangle(2, 2);
            Assert.AreEqual(Rectangle.IsRectangle(triangle), false);
            Assert.AreEqual(Rectangle.IsRectangle(rectangle), true);
            Assert.AreEqual(Triangle.IsTriangle(triangle), true);
            Assert.AreEqual(Triangle.IsTriangle(rectangle), false);
        }
    }
}
