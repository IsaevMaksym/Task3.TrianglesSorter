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
        public const string CREATION_FAIL = "Can't create triangle";
        public const string CREATION_SUCCESSFUL = "Triangle has been added";
        public const string CONVERTATION_FAIL = "Fail to convert inserted arguments";
        #endregion

        #region Private Fields

        private TrianglesList _triangles = new TrianglesList();
        private IImputOutput _io;
        private StringValidator _validator = new StringValidator();
        #endregion

        public TriangleController(IImputOutput imputOutput)
        {
            _io = imputOutput;
        }

        public void Start(string[] args)
        {
            CheckInsertedArgs(args);

            InsertNewTriangle();

            if (!_triangles.IsEmpty)
            {
                _io.ShowTrianglesList(_triangles.GetTrinaglesList());

                while (_io.ISStartOver())
                {
                    InsertNewTriangle();

                    _io.ShowTrianglesList(_triangles.GetTrinaglesList());
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
                _triangles = _validator.CheckInsertedString(args);

                if (_triangles.IsEmpty)
                {
                    _io.ShowMsg(CONVERTATION_FAIL);
                    _io.ShowRules(RULES);
                }
                else
                {
                    _io.ShowTrianglesList(_triangles.GetTrinaglesList());
                }
               
            }
        }

        private void InsertNewTriangle()
        {
            while (_io.DoesUserWantInputeTriangle())
            {

                TrianglesList trianglesList = _validator.CheckInsertedString(_io.GetNewTriangleString());

                for (int i = 0; i < trianglesList.Triangles.Count; i++)
                {
                    if (_triangles.AddTriangles(trianglesList.Triangles[i]))
                    {
                        _io.ShowMsg(CREATION_SUCCESSFUL);
                        continue;
                        
                    }
                    else
                    {
                        _io.ShowMsg(CREATION_FAIL);
                    }
                }
                

            }
        }

    }
}

