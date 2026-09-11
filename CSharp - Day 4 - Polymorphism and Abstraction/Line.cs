using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_4___Polymorphism_and_Abstraction
{
    class Line
    {
        public Points p1, p2;
        public Line(int x1, int y1, int x2, int y2)
        {
            p1 = new Points(x1, y1);
            p2 = new Points(x2, y2);
        }
        public double GetLength()
        {
            return Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
        }
    }
}
