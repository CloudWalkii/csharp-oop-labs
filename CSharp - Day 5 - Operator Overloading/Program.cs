using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_oop_labsDay01_3dPointAndFraction;

namespace CSharp___Day_5___Operator_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _3dPoint p1 = new _3dPoint(1, 2, 3);
            _3dPoint p2 = new _3dPoint(1, 2, 3);
            Console.WriteLine($"p1 == p2 : {p1 == p2}"); 

            
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 4);
            Fraction f3 = f1 + f2;

            
            Fraction f4 = 5; 
            Console.WriteLine($"Implicit conversion : {f4.numerator}/{f4.denominator}");

            
            double value = (double)f1; 
            Console.WriteLine($"Explicit conversion : {value}");
        }
    }
}
