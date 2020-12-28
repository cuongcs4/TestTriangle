using System;

namespace Triangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type value for x and y coordinate: ");
            var dataInput = Console.ReadLine().Split(' ');
            int coordinateX = Convert.ToInt32(dataInput[0]);
            int coordinateY = Convert.ToInt32(dataInput[1]);

            Point testPoint = new Point(coordinateX, coordinateY);
            testPoint.toString();
            TriangleModel testTriangle = new TriangleModel();
            testTriangle.toString();
        }
    }
}
