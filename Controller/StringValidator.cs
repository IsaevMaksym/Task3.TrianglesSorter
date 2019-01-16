using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using TriangleLogic;
using System.Globalization;

namespace Controller
{
    class StringValidator
    {
        #region Constants

        const string SEARCH_PATTERN = @"(\w+)\,(\d+\.?\d*)\,(\d+\.?\d*)\,(\d+\.?\d*)";         // it means [\w- any alp.-digit], [\. screening], [+ prev. is 1+ times], [\d any digit]
        const string EXCEPTION_MESSAGE = "Error. Wrong inserted message format";

        #endregion
                
        public bool CheckInsertedString(out TrianglesList list, params string[] args) 
        {
            string s = "";
            string[] arr = null;
            bool isOk = false;
            list = null;

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

            arr = GetTriangleFormatedArr(s);

            if (arr != null)
            {
                list = GetTrianglesList(arr);
                isOk = true;
            }

            return isOk;
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

            if (arr == null)
            {
                return trianglesList;
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    string[] name = arr[i].Split(',');

                    trianglesList.CheckTriangleString(name[0], GetDbl(name[1]), GetDbl(name[2]), GetDbl(name[3]));
                }
            }

            return trianglesList;
        }

        private double GetDbl(string s)
        {
            
            string sNew = s.Replace('.', ',');
            double d = 0.0;
            double.TryParse(s, out d);
            return d;
        }
    }
}
