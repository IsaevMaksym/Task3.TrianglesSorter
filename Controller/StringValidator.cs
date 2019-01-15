using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using BL;

namespace Controller
{
    class StringValidator
    {
        const string SEARCH_PATTERN = @"(\w+)\,(\d+\.?\d*)\,(\d+\.?\d*)\,(\d+\.?\d*)";         // it means [\w- any alp.-digit], [\. screening], [+ prev. is 1+ times], [\d any digit]


        public TrianglesList CheckInsertedString(params string[] args)
        {
            string s = "";

            if (args.Length > 1)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    s += args[i];
                }
            }
            else
            {
                s = args[0];
            }

            return GetTrianglesList(GetTriangleFormatedArr(s));
        }
        
        private string[] GetTriangleFormatedArr(string s)
        {
            Regex regex = new Regex(SEARCH_PATTERN, RegexOptions.IgnoreCase);
            MatchCollection matches = null;
            string[] arr = null;

            matches = regex.Matches(s);

            if (matches.Count > 0)
            {
                arr = new string[matches.Count];

                for (int i = 0; i < matches.Count; i++)
                {
                    arr[i] = matches[i].Value;
                }
            }

            return arr;
        }

        private TrianglesList GetTrianglesList(string[] arr)
        {
            TrianglesList trianglesList = new TrianglesList();

            for (int i = 0; i < arr.Length; i++)
            {
                string[] name = arr[i].Split(',');

                trianglesList.CheckTriangleString(name[0], GetDbl(name[1]), GetDbl(name[2]), GetDbl(name[3]));
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
