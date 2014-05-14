using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Defining_Classes_Part_II_Constructor
{
    static class PathStorage
    {
        static public Path LoadPaths(string filePath)
        {
            StreamReader textFile = new StreamReader(filePath, Encoding.GetEncoding("windows-1251"));
            Path currPath = new Path();
            
                while (!textFile.EndOfStream)
                {
                            if (textFile.ReadLine().Trim() == "newPoint")
                            {
                                double x = double.Parse(textFile.ReadLine());
                                double y = double.Parse(textFile.ReadLine());
                                double z = double.Parse(textFile.ReadLine());
                                Point3D curPoint = new Point3D(x, y, z);
                                currPath.AddPoint(curPoint);
                            }   
                }
           return currPath;
            
        }
        static public void SavePaths(Path currPath, string filePath)
        {
            StreamWriter textFile = new StreamWriter(filePath);


            for (int i = 0; i < currPath.Sequence.Count; i++)
            {
                textFile.WriteLine("newPoint");
                textFile.WriteLine(currPath.Sequence[i].X);
                textFile.WriteLine(currPath.Sequence[i].Y);
                textFile.WriteLine(currPath.Sequence[i].Z);
            }
            textFile.Close();
        }
    }
}
