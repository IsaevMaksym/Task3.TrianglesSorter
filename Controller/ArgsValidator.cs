using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using BL;

namespace Controller
{
    class ArgsValidator
    {
        const string SEARCH_PATTERN = @"(\w+)\,(\d+\.?\d*)\,(\d+\.?\d*)\,(\d+\.?\d*)";         // it means [\w- any alp.-digit], [\. screening], [+ prev. is 1+ times], [\d any digit]


        public TrianglesList CheckInsertedString(string[] args)
        {
            TrianglesList trianglesList = null;
            Regex regex = new Regex(SEARCH_PATTERN, RegexOptions.IgnoreCase);
            MatchCollection matches = null;
            string s = "";
            string[] arr = null;


            for (int i = 0; i < args.Length; i++)
            {
                s += args[i];
            }

            matches = regex.Matches(s);

            if (matches.Count > 0)
            {
                arr = new string[matches.Count];

                for (int i = 0; i < matches.Count; i++)
                {
                    arr[i] = matches[i].Value;
                }

                trianglesList = GetTrianglesList(arr);
            }

            return trianglesList;
        }

        private TrianglesList GetTrianglesList(string[] arr)
        {
            TrianglesList trianglesList = new TrianglesList();

            for (int i = 0; i < arr.Length; i++)
            {
                string[] name = arr[i].Split(',');

                trianglesList.AddTriangle(name[0], GetDbl(name[1]), GetDbl(name[2]), GetDbl(name[3]));
            }

            return trianglesList;
        }

        private double GetDbl(string s)
        {
            string sNew = s.Replace('.', ',');
            double d = 0d;
            double.TryParse(s, out d);
            return d;
        }
    }
}
