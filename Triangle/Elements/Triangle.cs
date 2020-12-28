﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle.Elements
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
        private bool IsTriangle(Point firstPointInput, Point secondPointInput, Point thirdPointInput)
        {
            if (firstPointInput.calculeDistance(secondPointInput) < thirdPointInput.calculeDistance(secondPointInput) + thirdPointInput.calculeDistance(firstPointInput)
                && thirdPointInput.calculeDistance(firstPointInput) < thirdPointInput.calculeDistance(secondPointInput) + firstPointInput.calculeDistance(secondPointInput)
                && thirdPointInput.calculeDistance(secondPointInput) < thirdPointInput.calculeDistance(firstPointInput) + firstPointInput.calculeDistance(secondPointInput))
                return true;
            return false;
        }
        public bool IsEquilateralTriangle()
        {
            double firstSide = firstPoint.calculeDistance(secondPoint);
            double secondSide = secondPoint.calculeDistance(thirdPoint);
            double thirdSide = thirdPoint.calculeDistance(firstPoint);
            return firstSide == secondSide && secondSide == thirdSide && thirdSide == firstSide;
        }
        public bool IsIsoscelesTriangle()
        {
            double firstSide = firstPoint.calculeDistance(secondPoint);
            double secondSide = secondPoint.calculeDistance(thirdPoint);
            double thirdSide = thirdPoint.calculeDistance(firstPoint);
            return firstSide == secondSide || secondSide == thirdSide || thirdSide == firstSide;
        }
        public bool IsRightTriangle()
        {
            double firstSide = firstPoint.calculeDistance(secondPoint);
            
            double secondSide = secondPoint.calculeDistance(thirdPoint);
            double thirdSide = thirdPoint.calculeDistance(firstPoint);
            Console.Write(firstSide + " " + secondSide + " " + thirdSide);
            double a = firstSide * firstSide;
            double b = secondSide * secondSide;
            double c = thirdSide * thirdSide;
            Console.Write(a + " " + b + " " + c);
            return a + b == c || b + c == a || c + a == b;
        }
        public bool IsScaleneTriangle()
        {
            return IsEquilateralTriangle() == false
                && IsIsoscelesTriangle() == false
                && IsRightTriangle() == false;
        }
        public double calculatePerimeter()
        {
            double firstSide = firstPoint.calculeDistance(secondPoint);
            double secondSide = secondPoint.calculeDistance(thirdPoint);
            double thirdSide = thirdPoint.calculeDistance(firstPoint);
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
        private void TrowExceptionIfSideIsZero(Point firstPointInput, Point secondPointInput, Point thirdPointInput)
        {
            if (firstPointInput.isZeroValueDistance(secondPointInput) == true
                || thirdPointInput.isZeroValueDistance(secondPointInput) == true
                || thirdPointInput.isZeroValueDistance(firstPointInput) == true)
                throw new ArgumentException($"Have a side value is 0, must more 0");
        }
    }
}
