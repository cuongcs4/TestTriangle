using System;

namespace Triangle
{
    public class Point
    {
        private int _coordinateX;
        private int _coordinateY;

        public int coordinateX { get => _coordinateX; set => _coordinateX = value; }
        public int coordinateY { get => _coordinateY; set => _coordinateY = value; }
        public Point()
        {
            coordinateX = 0;
            coordinateY = 0;
        }
        public Point(int coordinateX, int coordinateY)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
        }
        public void toString()
        {
            Console.WriteLine("Point value" + " : (" + this.coordinateX + ", " + this.coordinateY + ")");
        }
        public double calculateDistance(Point secondPoint)
        {
            double distance;
            distance = (this.coordinateX - secondPoint.coordinateX) * (this.coordinateX - secondPoint.coordinateX);
            distance += (this.coordinateY - secondPoint.coordinateY) * (this.coordinateY - secondPoint.coordinateY);
            distance = Math.Sqrt(distance);
            return distance;
        }
        public bool isZeroValueDistance(Point secondPoint)
        {
            return this.calculateDistance(secondPoint) == 0;
        }
        public bool comparerPoint(Point secondPoint)
        {
            bool lesPointsSontIdentiques = false;

            if (this.coordinateX == secondPoint.coordinateX && this.coordinateY == secondPoint.coordinateY)
            {
                lesPointsSontIdentiques = true;
            }

            return lesPointsSontIdentiques;
        }
    }
}
