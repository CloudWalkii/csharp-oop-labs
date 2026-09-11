using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_4___Polymorphism_and_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape c = new Square(2, 2, 5);

            Shape r = new Rectangle(3, 6, 7, 9);

            Shape d = new Circle(5);

            Shape[] s = new Shape[] { c, r, d };

            Picture pics = new Picture(s);
            pics.DisplayShapeAreas();
        }
    }
}
