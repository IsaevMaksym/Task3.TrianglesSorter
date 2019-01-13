using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class TriangleCreator
    {

        public Triangle GetNewTriangle(string name, double[] sides)
        {
            if (!CheckSides(sides))
            {
                throw new TrianglesExeption();
            }
            else
            {
                return new Triangle(name, sides);
            }
            
        }

        public bool CheckSides(params double[] sides)
        {
            bool isSidesOK = false;

            if ((sides.Length!=3)||(sides[0]==0)|| (sides[1] == 0)|| (sides[2] == 0))
            {
                return isSidesOK;
            }
            else
            {
                if (IsTriangleEquilateral(sides))
                {
                    isSidesOK = true;
                }
                else if (IsTriangleIsosceles(sides))
                {
                    isSidesOK = true;
                }
                else if (IsTriangleVersatile(sides))
                {
                    isSidesOK = true;
                }
                return isSidesOK;
            }

        }

        private bool IsTriangleVersatile(double[] sides)         //All sides are different
        {
            return ((sides[0] + sides[1] > sides[2]) || (sides[0] + sides[2] > sides[1]) || (sides[2] + sides[1] > sides[0]));
        }

        private bool IsTriangleIsosceles(double[] sides)         //2 sides are equal.
        {
            bool isOK = false;

            if ((sides[0] == sides[1]) && (sides[0] + sides[1] < sides[2]))
            {
                isOK = true;
            }
            else if ((sides[0] == sides[2]) && (sides[0] + sides[2] < sides[1]))
            {
                isOK = true;
            }
            else if ((sides[2] == sides[1]) && (sides[2] + sides[1] < sides[0]))
            {
                isOK = true;
            }
            return isOK;
        }

        private bool IsTriangleEquilateral(double[] sides)       //All sides are equals
        {
            return ((sides[0] == sides[1]) && (sides[0] == sides[2]));
        }
    }
}
