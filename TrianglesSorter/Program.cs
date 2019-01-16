using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;
using ConsoleIO;


namespace TrianglesSorter
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IConsoleOperation IO = new ConsOperations();
            TriangleController sorter = new TriangleController(IO);
            sorter.Start(args);

        }
    }
}
