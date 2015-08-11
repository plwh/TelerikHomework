// Problem 4: Create a static class PathStorage with static methods to save and load paths from a text file.

using System;
using System.IO;

namespace _01._3DPoint
{
    public static class PathStorage
    {
        public static Path path = new Path();

        public static void SavePathToFile(string filePath, Path points )
        {
            StreamWriter writer = new StreamWriter(filePath);
            using (writer)
            {
                for (int i = 0; i < points.Points.Count; i++)
                {
                    string line = string.Format("{0} {1} {2}", points.Points[i].X,  points.Points[i].Y, points.Points[i].Z);
                    writer.WriteLine(line);   
                }
            }
        }

        public static void LoadPathFromFile(string filePath)
        {
            StreamReader reader = new StreamReader(filePath);
            using (reader)
            {
                string currLine = reader.ReadLine();
                while (currLine != null)
                { 
                    double x = 0, y = 0, z = 0;
                    string[] readCoordinates = currLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    x = double.Parse(readCoordinates[0]);
                    y = double.Parse(readCoordinates[1]);
                    z = double.Parse(readCoordinates[2]);

                    path.AddPoint(x, y, z);

                    currLine = reader.ReadLine();
                }
            }
        }
    }
}
