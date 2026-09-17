using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_6___Overriding_and_Inheritance
{
    class Point3D
    {
        public int X, Y, Z;
        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x) : this(x, 0, 0) { }
        public Point3D(int x, int y) : this(x, y, 0) { }
        public Point3D(int x, int y, int z)
        {
            X = x; Y = y; Z = z;
        }
        public static bool operator==(Point3D g , Point3D h)
        {
            if (ReferenceEquals(g, h)) return true;
            if (g is null || h is null) return false;
            return g.X == h.X && g.Y == h.Y && g.Z == h.Z;
        }
        public static bool operator !=(Point3D g, Point3D h)
        {
            return !(g == h);
        }
        public override bool Equals(object obj)
        {
            if (obj is Point3D)
            {
                Point3D h = obj as Point3D;
                return this.X == h.X && this.Y == h.Y && this.Z == h.Z;
            }
            else return false;
        }
        public override string ToString() => $"X = {X}\t Y = {Y}\t Z = {Z}";

    }
}
