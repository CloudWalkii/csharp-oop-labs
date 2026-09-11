using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_4___Polymorphism_and_Abstraction
{
    class Rectangle : Shape
    {
        public Points p1, p2;

        public Rectangle()
        {
            p1 = new Points(0, 0);
            p2 = new Points(0, 0);
        }
        public Rectangle(int x1, int y1, int x2, int y2)
        {
            p1 = new Points(x1, y1);
            p2 = new Points(x2, y2);
        }
        public override double CalculateArea()
        {
            int w = Math.Abs(p1.X - p2.X);
            int h = Math.Abs(p1.Y - p2.Y);
            return w * h;
        }
    }
}
