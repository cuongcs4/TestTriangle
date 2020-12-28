using System;
using NUnit.Framework;

namespace Triangle.Test
{
    [TestFixture]
    public class PointUnitTest
    {
        private Point _point;
        [SetUp]
        public void Setup()
        {
            _point = new Point();
        }
        public void Setup(int coordinateX, int coordinateY)
        {
            _point = new Point(coordinateX, coordinateY);
        }
        [TestCase(0, 0, 1, 0, 1)]
        public void TestCalculateDistance(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY, double distance)
        {
            _point.coordinateX = firstPointCoordinateX;
            _point.coordinateY = firstPointCoordinateY;
            Point secondPoint = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Assert.AreEqual(distance, _point.calculateDistance(secondPoint));
        }
    }
}
