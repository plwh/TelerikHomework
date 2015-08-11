using System;

namespace _01._3DPoint
{
    class _3DPoint_Main
    {
        static void Main()
        {
            ThreeDPoint firstPoint = new ThreeDPoint(1.3, 3.0, 2.7);
            ThreeDPoint secondPoint = new ThreeDPoint(3.2, 2.5, 1.0);
 

            Console.WriteLine("First point coordinates: {0}", firstPoint);
            Console.WriteLine("Second point coordinates: {0}", secondPoint);

            Console.WriteLine("Distance between first and second point: {0:F2}", CalculateDistance.CalcDistance(firstPoint, secondPoint));

            Path listOfPaths = new Path();
            listOfPaths.AddPoint(firstPoint);
            listOfPaths.AddPoint(secondPoint);

            PathStorage.SavePathToFile(@"../../PathStorageTest.txt",listOfPaths);
            PathStorage.LoadPathFromFile(@"../../PathStorageTest.txt");

            Console.WriteLine("List of paths stored in text file:");
            foreach (ThreeDPoint point in listOfPaths.Points)
            {
                Console.WriteLine(point);
            }
        }
    }
}
