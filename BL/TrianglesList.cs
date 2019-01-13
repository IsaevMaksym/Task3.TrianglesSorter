using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class TrianglesList
    {
        #region CONST

        public const string EXEPTION_MESSAGE = "Error! Triangle can't be empty";

        #endregion

        #region Private Fields

        private List<Triangle> triangles = new List<Triangle>();
        private TriangleCreator creator = new TriangleCreator();

        #endregion

        public bool IsEmpty
        {
            get
            {
                return triangles.Count == 0;
            }
        }

        public List<Triangle> Triangles { get => triangles; private set => triangles = value; }

        public bool AddTriangle(string name, double[] sides)
        {
            bool isAdded = false;
            if (creator.CheckSides(sides))
            {
                triangles.Add(creator.GetNewTriangle(name, sides));
                isAdded = true;
            }

            return isAdded;            
        }

        private void ReverseSortTriangles()
        {
            triangles.Sort();
            triangles.Reverse();
        }

        public void ShowTriangles()
        {

            foreach (var item in triangles)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public string[] GetTrinaglesList()
        {
            int i = -1;
            string[] arr = new string[triangles.Count];

            foreach (var item in triangles)
            {
                ++i;
                arr[i] = item.ToString();
            }

            return arr;
        }

    }
}
