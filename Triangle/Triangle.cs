using System;

namespace Triangle
{
    public class TriangleModel
    {
        private Point _firstPoint;
        private Point _secondPoint;
        private Point _thirdPoint;

        public Point firstPoint { get => _firstPoint ; set => _firstPoint = value; }
        public Point secondPoint { get => _secondPoint; set => _secondPoint = value; }
        public Point thirdPoint { get => _thirdPoint; set => _thirdPoint = value; }

        public TriangleModel()
        {
            firstPoint = new Point(0, 0);
            secondPoint = new Point(0, 1);
            thirdPoint = new Point(1, 0);
        }

        public TriangleModel(Point firstPointInput, Point secondPointInput, Point thirdPointInput)
        {
            TrowExceptionIfSideIsZero(firstPointInput, secondPointInput, thirdPointInput);
            if (IsTriangle(firstPointInput, secondPointInput, thirdPointInput) == false)
                throw new ArgumentException($"Triangle with points: A={firstPointInput}, B={secondPointInput} and C={thirdPointInput} does not exist");
            firstPoint = firstPointInput;
            secondPoint = secondPointInput;
            thirdPoint = thirdPointInput;
        }
        public bool IsTriangle(Point firstPointInput, Point secondPointInput, Point thirdPointInput)
        {
            return firstPointInput.calculateDistance(secondPointInput) < thirdPointInput.calculateDistance(secondPointInput) + thirdPointInput.calculateDistance(firstPointInput);
        }
        public bool IsEquilateralTriangle()
        {
            double firstSide = firstPoint.calculateDistance(secondPoint);
            double secondSide = secondPoint.calculateDistance(thirdPoint);
            double thirdSide = thirdPoint.calculateDistance(firstPoint);
            return firstSide == secondSide && secondSide == thirdSide && thirdSide == firstSide;
        }
        public bool IsIsoscelesTriangle()
        {
            double firstSide = firstPoint.calculateDistance(secondPoint);
            double secondSide = secondPoint.calculateDistance(thirdPoint);
            double thirdSide = thirdPoint.calculateDistance(firstPoint);
            return firstSide == secondSide || secondSide == thirdSide || thirdSide == firstSide;
        }
        public bool IsRightTriangle()
        {
            double firstSide = firstPoint.calculateDistance(secondPoint);
            double secondSide = secondPoint.calculateDistance(thirdPoint);
            double thirdSide = thirdPoint.calculateDistance(firstPoint);
            return Math.Pow(firstSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(thirdSide, 2)
                || Math.Pow(secondSide, 2) == Math.Pow(firstSide, 2) + Math.Pow(thirdSide, 2)
                || Math.Pow(thirdSide, 2) == Math.Pow(secondSide, 2) + Math.Pow(firstSide, 2);
        }
        public bool IsScaleneTriangle()
        {
            return IsEquilateralTriangle() == false
                && IsIsoscelesTriangle() == false
                && IsRightTriangle() == false;
        }
        public double calculatePerimeter()
        {
            double firstSide = firstPoint.calculateDistance(secondPoint);
            double secondSide = secondPoint.calculateDistance(thirdPoint);
            double thirdSide = thirdPoint.calculateDistance(firstPoint);
            return firstSide + secondSide + thirdSide;
        }
        public void toString()
        {
            Console.Write("#1: ");
            firstPoint.toString();
            Console.Write("#2: ");
            secondPoint.toString();
            Console.Write("#3: ");
            thirdPoint.toString();
        }
        public void TrowExceptionIfSideIsZero(Point firstPointInput, Point secondPointInput, Point thirdPointInput)
        {
            if (firstPointInput.isZeroValueDistance(secondPointInput) == false 
                || thirdPointInput.isZeroValueDistance(secondPointInput) == false
                || thirdPointInput.isZeroValueDistance(firstPointInput) == false)
                throw new ArgumentException($"Have a side value is 0, must more 0");
        }
    }
}
