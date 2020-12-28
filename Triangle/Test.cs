using NUnit.Framework;
using System;
using Triangle.Elements;

namespace Triangle
{
    [TestFixture]
    public class TriangleModelTest
    {
        [Test]
        public void AnalyzeTest()
        {
            var point1 = new Point(0, 0);
            var point2 = new Point(1, 0);
            var point3 = new Point(0, 1);
            var Triangle1 = new TriangleModel(point1, point2, point3);
            var result = Triangle1.IsRightTriangle();
            // Tests if the triangle is right triangle
            Assert.IsTrue(result);
        }
        [Test]
        public void AnalyzeTest1()
        {
            var point1 = new Point(0, 0);
            var point2 = new Point(1, 0);
            var point3 = new Point(0, 1);
            var Triangle1 = new TriangleModel(point1, point2, point3);
            var result = Triangle1.IsIsoscelesTriangle();
            // Tests if the triangle is right triangle
            Assert.IsTrue(result);
        }
    }
}
