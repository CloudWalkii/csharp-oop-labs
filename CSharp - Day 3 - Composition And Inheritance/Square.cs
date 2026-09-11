using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_3___Composition_And_Inheritance
{
    class Square : Rectangle
    {
        public Square() : base()
        {
        }
        public Square(int x1, int y1, int side) : base(x1 , y1 , x1 + side , y1 + side)
        {
        }
    }
}
