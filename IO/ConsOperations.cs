using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace ConsoleIO
{
    public class ConsOperations : IImputOutput
    {
        #region CONST
        public const int CLOSING_ITERATION_TIME = 800;
        public const int CLOSING_ITERATIONS_COUNT = 3;
        public const string ENTER_TRIANGLE = "Would you like to input new Triangle?(y/yes?...) ";
        public const string PRESS_ANY_KEY = "Press any key...";
        public const string CLOSING_MESSAGE = "Closing app";
        public const string USER_ANSWER_Y = "y";
        public const string USER_ANSWER_YES = "yes";
        public const string ENTER_SIDE = "Enter triangle side length(e.g. 1,23): ";
        public const string GET_TRIANGLE_NAME = "Enter triangle name: ";
        public const string START_AGAIN = "Would you like to start again?(y/yes)  ";
        public const string TRIANGLES_ARR = "============= Triangles list: ===============";

        #endregion

        public void ShowRules(string rules)
        {
            Console.WriteLine(rules);
            Console.WriteLine(PRESS_ANY_KEY);

            Console.ReadKey();
        }

        public void CloseApp()
        {
            Console.Write(CLOSING_MESSAGE);

            for (int i = 0; i < CLOSING_ITERATIONS_COUNT; i++)
            {
                System.Threading.Thread.Sleep(CLOSING_ITERATION_TIME);
                Console.Write(".");
            }
        }

        public bool DoesUserWantInputeTriangle()
        {
            bool isAnswerYes = false;

            Console.Write(ENTER_TRIANGLE);

            string answer = Console.ReadLine().ToLower().Trim();

            if (answer == USER_ANSWER_Y || answer == USER_ANSWER_YES)
            {
                isAnswerYes = true;
            }
            return isAnswerYes;

        }

        public double[] GetTriangleSides()
        {
            double[] sides = new double[3];

            for (int i = 0; i < sides.Length; i++)
            {
                sides[i] = GetUserSide();
            }

            return sides;
        }

        private double GetUserSide()
        {
            double value = 0.0;

            do
            {
                Console.Clear();
                Console.Write(ENTER_SIDE);
            } while (!double.TryParse(Console.ReadLine(), out value));

            return value;
        }

        public void ShowTrianglesList(string[] trianglesArr)
        {

            if (trianglesArr.Length > 0)
            {

                Console.Clear();
                Console.WriteLine(TRIANGLES_ARR);

                for (int i = 0; i < trianglesArr.Length; i++)
                {
                    Console.WriteLine(trianglesArr[i]);
                }

                Console.WriteLine(PRESS_ANY_KEY);
                Console.ReadKey();
            }

        }

        public string GetTriangleName()
        {
            Console.WriteLine(GET_TRIANGLE_NAME);
            string s;
            do
            {
                s = Console.ReadLine().Trim();
            } while (String.IsNullOrWhiteSpace(s));

            return s;
        }

        public bool ISStartOver()
        {

            bool isAnswerYes = false;

            Console.Write(START_AGAIN);

            string answer = Console.ReadLine().ToLower().Trim();

            if (answer == USER_ANSWER_Y || answer == USER_ANSWER_YES)
            {
                isAnswerYes = true;
            }
            return isAnswerYes;

        }
    }
}
