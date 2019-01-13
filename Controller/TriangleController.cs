using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;



namespace Controller
{
    public class TriangleController
    {

        #region CONST
        public const string RULES = "Insert triangles information in format<TriangleName>,<TriangleSide>,<TriangleSide>,<TriangleSide>.";

        #endregion

        #region Private Fields

        private TrianglesList triangles = new TrianglesList();
        private IImputOutput _io;
        private ArgsValidator _validator = new ArgsValidator();
        #endregion

        public TriangleController(IImputOutput imputOutput)
        {
            _io = imputOutput;
        }

        public void Start(string[] args)
        {
            CheckInsertedArgs(args);

            InsertNewTriangle();

            if (!triangles.IsEmpty)
            {
                _io.ShowTrianglesList(triangles.GetTrinaglesList());

                while (_io.ISStartOver())
                {
                    InsertNewTriangle();

                    _io.ShowTrianglesList(triangles.GetTrinaglesList());
                }
            }

            _io.CloseApp();
        }

        private void CheckInsertedArgs(string[] args)
        {

            if (args.Length == 0)
            {
                _io.ShowRules(RULES);
            }
            else
            {
                triangles = _validator.CheckInsertedString(args);

                if (triangles.IsEmpty)
                {
                    _io.ShowRules(RULES);
                }
                else
                {
                    _io.ShowTrianglesList(triangles.GetTrinaglesList());
                }
               
            }
        }

        private void InsertNewTriangle()
        {
            while (_io.DoesUserWantInputeTriangle())
            {
                if (triangles.AddTriangle(_io.GetTriangleName(), _io.GetTriangleSides()))
                {
                    continue;
                }
                else
                {
                    _io.ShowErrorMsg("Can't create triangle");
                }

            }
        }

    }
}

