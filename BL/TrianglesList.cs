using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TrianglesList
    {
        public const string EXEPTION_MESSAGE = "Error! Triangle can't be empty";

        public void AddTriangle(string name, double[] sides)
        {
            triangles.Add(creator.GetNewTriangle(name, sides));

        }

        public void SortTriangles()
        {
            triangles.Sort();
        }

        public void ShowTriangles()
        {

            foreach (var item in triangles)
            {
                Console.WriteLine(item.ToString());
            }
        }

      
        public List<Triangle> Triangles { get => triangles;  private set => triangles = value; }

        

        private void dsad()
        {
            triangles.Add(new Triangle("triangle1", 12, 14, 25));
            triangles.Add(new Triangle("triangle2", 10, 12, 22));
            triangles.Add(new Triangle("triangle3", 15.5, 12.3, 26));
            triangles.Add(new Triangle("triangle4", 5.3, 14.5, 15));
            triangles.Add(new Triangle("triangle5", 2, 3, 4));
            triangles.Add(new Triangle("triangle6", 2, 2, 1));
            triangles.Add(new Triangle("triangle7", 12, 14, 18));
            triangles.Add(new Triangle("triangle8", 6.8, 7.3, 12));
            triangles.Add(new Triangle("triangle9", 50, 45.6, 88));
            triangles.Add(new Triangle("triangle10", 100, 100, 20));
            triangles.Add(new Triangle("triangle1", 12, 14, 25));
            triangles.Add(new Triangle("triangle2", 10, 12, 22));
            triangles.Add(new Triangle("triangle3", 15.5, 12.3, 26));
            triangles.Add(new Triangle("triangle4", 5.3, 14.5, 15));
            triangles.Add(new Triangle("triangle5", 2, 3, 4));
            triangles.Add(new Triangle("triangle6", 2, 2, 1));
            triangles.Add(new Triangle("triangle7", 12, 14, 18));
            triangles.Add(new Triangle("triangle8", 6.8, 7.3, 12));
            triangles.Add(new Triangle("triangle9", 50, 45.6, 88));
            triangles.Add(new Triangle("triangle10", 100, 100, 20));
            triangles.Add(new Triangle("triangle1", 12, 14, 25));
            triangles.Add(new Triangle("triangle2", 10, 12, 22));
            triangles.Add(new Triangle("triangle3", 15.5, 12.3, 26));
            triangles.Add(new Triangle("triangle4", 5.3, 14.5, 15));
            triangles.Add(new Triangle("triangle5", 2, 3, 4));
            triangles.Add(new Triangle("triangle6", 2, 2, 1));
            triangles.Add(new Triangle("triangle7", 12, 14, 18));
            triangles.Add(new Triangle("triangle8", 6.8, 7.3, 12));
            triangles.Add(new Triangle("triangle9", 50, 45.6, 88));
            triangles.Add(new Triangle("triangle10", 100, 100, 20));
        }

        private List<Triangle> triangles = new List<Triangle>();
        private TriangleCreator creator = new TriangleCreator();
       
    }
}
