using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace State
{
    public class EraserTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Show Eraser Icon.");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase SomeThings.");
        }
    }
}