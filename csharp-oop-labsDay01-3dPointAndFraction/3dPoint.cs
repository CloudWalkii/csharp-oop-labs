using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_labsDay01_3dPointAndFraction
{
    class _3dPoint
    {
        public double X, Y, Z;
        public _3dPoint()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public _3dPoint(double x, double y)
        {
            X = x;
            Y = y;

        }

        public _3dPoint(double x, double y, double z) : this(x, y)
        {
            Z = z;
        }
        public void DisplayPoints()
        {
            Console.WriteLine($"X = {X} \tY = {Y} \tZ = {Z}");
        }
        public double CalculateDistance(_3dPoint P1, _3dPoint P2)
        {
            return Math.Abs(P1.X - P2.X);
        }
    }
}
