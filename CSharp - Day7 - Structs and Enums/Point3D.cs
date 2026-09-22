using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day7___Structs_and_Enums
{
    class Point3D
    {
       public int X, Y, Z;
        public Point3D() { }
        public Point3D(int x) : this(x ,0 ,0) { }
        public Point3D(int x , int y) : this(x ,y ,0) { }
        public Point3D(int x , int y ,int z) { }

        public static bool operator==(Point3D P , Point3D P2)
        {
            return P2.X == P.X && P2.Y == P.Y && P2.Z == P.Z; 
        }public static bool operator!=(Point3D P, Point3D P2)
        {
            return !(P == P2);
        }

        public void DisplayPoints()
        {
            Console.WriteLine($"X = {X}\tY = {Y}\tZ = {Z}");
        }

        public void ChangeCoordinates( int newX ,int newY , int newZ)
        {
            X = newX;
            Y = newY;
            Z = newZ;
        }
        
    }
}
