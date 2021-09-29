using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountFigure
{
    //зберігання індексів масива
    public class Data
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Data(int intX, int intY)
        {
            X = intX;
            Y = intY;
        }
        public Data()
        {

        }
    }
}
