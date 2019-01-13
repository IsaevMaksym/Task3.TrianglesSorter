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
            return new Triangle(name, sides);

        }

        public bool CheckSides(params double[] sides)
        {
            bool isSidesOK = false;

            if ((sides.Length != 3) || (sides[0] == 0) || (sides[1] == 0) || (sides[2] == 0))
            {
                return isSidesOK;
            }
            else
            {
                if (IsTriangleEquilateral(sides))
                {
                    isSidesOK = true;
                }
                
                else if (IsTriangleExist(sides))
                {
                    isSidesOK = true;
                }
                return isSidesOK;
            }
        }

        private bool IsTriangleExist(double[] sides)         //All sides are different
        {
            bool isOk = false;

            if (IsSidesGood(sides[0], sides[1], sides[2]))
            {
                isOk = true;
            }
            else if (IsSidesGood(sides[1], sides[2], sides[0]))
            {
                isOk = true;
            }
            else if (IsSidesGood(sides[2], sides[0], sides[1]))
            {
                isOk = true;
            }
            
            return isOk;
        }

        private bool IsSidesGood(params double[] sides)
        {
            bool isOk = false;

            if ((sides[0] < sides[2] && sides[1] < sides[2]) && (sides[0] + sides[1] > sides[2]))
            {
                isOk = true;
            }
            else if ((sides[0] == sides[1]) && (sides[0] + sides[1] > sides[2]))
            {
                isOk = true;
            }
            return isOk;
        }

        private bool IsTriangleEquilateral(double[] sides)       //All sides are equals
        {
            return ((sides[0] == sides[1]) && (sides[0] == sides[2]));
        }
    }
}
