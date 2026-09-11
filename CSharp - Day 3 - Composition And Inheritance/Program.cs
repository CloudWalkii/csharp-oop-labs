using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_3___Composition_And_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Line L = new Line(7 , 8 , 2 , 5);
            Console.WriteLine($"The Length of The Line is : {L.GetLength()}");

            Rectangle R = new Rectangle(2 , 6 , 8 , 9);
            Console.WriteLine($"The Area of The Rectangle is : {R.CalculateArea()}");

            Square S = new Square(2, 2, 5); 
            Console.WriteLine($"The Area of The Square is : {S.CalculateArea()}");
        }
    }
}
