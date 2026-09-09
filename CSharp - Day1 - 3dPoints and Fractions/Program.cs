using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_labsDay01_3dPointAndFraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _3dPoint p1 = new _3dPoint(8.67, 5.34, 9.36);
            _3dPoint p2 = new _3dPoint(3.12, 1.00, 4.50);

            // Call the method and pass the two point objects
            double distance = p1.CalculateDistance(p1, p2);
            Console.WriteLine($"The Distance is : {distance}");
        }
    }
}
