using System;
using NUnit.Framework;

namespace Triangle.Test
{
    [TestFixture]
    public class TestTriangle
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
        private TriangleModel _triangle;
        [SetUp]
        public void SetupTriangle()
        {
            _triangle = new TriangleModel();
        }

        // Test khoảng cách giữa 2 điểm 
        [TestCase(0, 0, 1, 0, 1)]
        [TestCase(0, 6, 3, 2, 5.0000000001)]
        [TestCase(0, 99999, 0, 0, 99999)]
        public void TestCalculateDistance(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY, double distance)
        {
            Point _point = new Point();
            _point.coordinateX = firstPointCoordinateX;
            _point.coordinateY = firstPointCoordinateY;
            Point secondPoint = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Assert.AreEqual(distance, _point.calculateDistance(secondPoint));
        }

        // Test 3 điểm có tạo thành tam giác 

        [TestCase(0, 0, 1, 0, 0, 1, true)]
        [TestCase(0, 0, 2, 2, 1, 1, false)]
        public void TestIsTriangle(int firstPointCoordinateX, int firstPointCoordinateY,
            int secondPointCoordinateX, int secondPointCoordinateY, int thirdPointCoordinateX, int thirdPointCoordinateY, bool expectedResult)
        {
            Point _point1 = new Point(firstPointCoordinateX, firstPointCoordinateY);
            Point _point2 = new Point(secondPointCoordinateX, secondPointCoordinateY);
            Point _point3 = new Point(thirdPointCoordinateX, thirdPointCoordinateY);
            Assert.AreEqual(expectedResult, _triangle.IsTriangle(_point1,_point2,_point3));
        }

        // Test 3 điểm có tạo thành tam giác cân

    }
}
