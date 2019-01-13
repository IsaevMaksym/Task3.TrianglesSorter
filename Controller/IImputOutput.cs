using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public interface IImputOutput
    {
        void ShowRules(string s);

        bool DoesUserWantInputeTriangle();

        void CloseApp();

        double[] GetTriangleSides();

        void ShowTrianglesList(string s);

        string GetTriangleName();

        bool ISStartOver();
    }
}
