using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_4___Polymorphism_and_Abstraction
{
    class Points
    {
        public int X, Y;
        public Points(int x) : this(x, 0)
        {

        }
        public Points(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
