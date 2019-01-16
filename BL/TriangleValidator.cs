using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TriangleLogic
{
    class TriangleValidator
    {

        public bool IsTriangleExist(params double[] sides)
        {
            bool isSidesOK = false;

            if ((sides.Length != 3) || (sides[0] <= 0) || (sides[1] <= 0) || (sides[2] <= 0))
            {
                return isSidesOK;
            }
            else
            {
                if (IsTriangleEquilateral(sides))
                {
                    isSidesOK = true;
                }

                else if (IsTriangleМersatile(sides))
                {
                    isSidesOK = true;
                }

                return isSidesOK;
            }
        }

        private bool IsTriangleМersatile(double[] sides)
        {
            bool isOk = false;

            if (IsSidesExist(sides[0], sides[1], sides[2]))
            {
                isOk = true;
            }
            else if (IsSidesExist(sides[1], sides[2], sides[0]))
            {
                isOk = true;
            }
            else if (IsSidesExist(sides[2], sides[0], sides[1]))
            {
                isOk = true;
            }

            return isOk;
        }

        private bool IsSidesExist(params double[] sides)
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

        private bool IsTriangleEquilateral(double[] sides)
        {
            return ((sides[0] == sides[1]) && (sides[0] == sides[2]));
        }
    }
}
