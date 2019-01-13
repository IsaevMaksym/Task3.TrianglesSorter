using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Controller
{
    class ArgsValidator
    {

        public static double[] CheckInsertedString(string[] args)
        {

            double[] dblArray = new double[args.Length];

            int i = 0;
            foreach (string c in args)
            {
                Regex regEx = new Regex("");

                if (double.TryParse(c, out dblArray[i]))
                {
                    if (dblArray[i] != 0)
                    {
                        i++;
                    }

                }

            }
            return dblArray;
        }

    }
}
