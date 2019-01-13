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

        private List<Triangle> _triangles = new List<Triangle>();
        private TriangleCreator _creator = new TriangleCreator();

        #endregion

        
        public bool IsEmpty
        {
            get
            {
                return _triangles.Count == 0;
            }
        }

        public List<Triangle> Triangles { get => _triangles; private set => _triangles = value; }

        public bool AddTriangle(string name, params double[] sides)
        {
            bool isAdded = false;
            if (_creator.CheckSides(sides))
            {
                _triangles.Add(_creator.GetNewTriangle(name, sides));
                isAdded = true;
            }

            return isAdded;            
        }

        private void ReverseSortTriangles()
        {
            _triangles.Sort();
            _triangles.Reverse();
        }

        public void ShowTriangles()
        {

            foreach (var item in _triangles)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public string[] GetTrinaglesList()
        {
            this.ReverseSortTriangles();

            int i = -1;
            string[] arr = new string[_triangles.Count];

            foreach (var item in _triangles)
            {
                ++i;
                arr[i] = item.ToString();
            }

            return arr;
        }

    }
}
