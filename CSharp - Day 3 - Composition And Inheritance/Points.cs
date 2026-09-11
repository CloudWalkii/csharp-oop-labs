using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_3___Composition_And_Inheritance
{
    class Points
    {
        public int X, Y;
        public Points(int x) : this(x ,0)
        {
           
        }
        public Points(int x , int y) 
        {
            X = x;
            Y = y;
        }
    }
}
