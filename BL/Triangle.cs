using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLogic
{
    public class Triangle : IComparable<Triangle>
    {
        #region Constants

        public const string STRING_FORMAT_MESSAGE = "[Triangle {0,F3}: {1}cm2. ";

        #endregion

        #region Private vearible

        private string _triangleName;
        private double _sideOne;
        private double _sideTwo;
        private double _sideThree;

        #endregion


        public Triangle(string name, params double[] sides)
        {
            _sideOne = sides[0];
            _sideTwo = sides[1];
            _sideThree = sides[2];
            _triangleName = name;
        }

        public double Perimetr
        {
            get
            {
                return (_sideOne + _sideTwo + _sideThree);
            }
        }

        public double Area
        {
            get
            {
                double PerimetrHalf = Perimetr / 2.0;

                return Math.Sqrt(PerimetrHalf * ((PerimetrHalf - _sideOne)
                    * (PerimetrHalf - _sideTwo) * (PerimetrHalf - _sideThree)));
            }
        }

        public string TriangleName { get => _triangleName; set => _triangleName = value; }
        public double SideOne { get => _sideOne; set => _sideOne = value; }
        public double SideTwo { get => _sideTwo; set => _sideTwo = value; }
        public double SideThree { get => _sideThree; set => _sideThree = value; }

        public int CompareTo(Triangle another)
        {
            return this.Area.CompareTo(another.Area);
        }

        public override string ToString()
        {
            return String.Format(STRING_FORMAT_MESSAGE, this.TriangleName, this.Area);
        }
    }
}
