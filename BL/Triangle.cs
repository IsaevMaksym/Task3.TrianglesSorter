using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Triangle:IComparable
    {
        #region Private vearible
        private string _triangleName;
        private double[] _triangleSides;
        #endregion

        public Triangle(string name,params double[] sides)
        {
            _triangleSides = new double[3];
            _triangleName = name;
            _triangleSides = sides;
        }
        
        public double HalfOfPerimetr
        {
            get
            {
                return 0.5 * (_triangleSides[0] + _triangleSides[1] + _triangleSides[2]);
            }
        }
        
        public double Area
        {
            get
            {
                return Math.Sqrt(HalfOfPerimetr * ((HalfOfPerimetr - _triangleSides[0])*(HalfOfPerimetr - _triangleSides[1])*(HalfOfPerimetr - _triangleSides[2])));
            }
        }

        public string TriangleName { get => _triangleName; set => _triangleName = value; }

        public int CompareTo(object obj)
        {
            Triangle compared= obj as Triangle;

            return this.Area.CompareTo(compared.Area);            
        }

        public override string ToString()
        {
            return string.Format("[{0}]: {1}cm2",_triangleName, Area);
        }
    }
}
