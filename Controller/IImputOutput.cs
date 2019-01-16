using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public interface IConsoleOperation
    {
        void ShowRules(string s);

        bool DoesUserWantInputeTriangle();

        void ShowClosingMessage();
                
        void ShowTrianglesList(string[] s);

        string GetNewTriangleString();

        bool ISStartOver();

        void ShowMessage(string error);
    }
}
