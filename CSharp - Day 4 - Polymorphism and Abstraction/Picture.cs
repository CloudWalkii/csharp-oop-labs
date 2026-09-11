using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_4___Polymorphism_and_Abstraction
{
    class Picture
    {
        public Shape[] S;
        public Picture( Shape[] s )
        {
            S = s;
        }
        public void DisplayShapeAreas()
        {
            foreach( Shape s in S)
                Console.WriteLine($"The Area is : {s.CalculateArea()}");
            
        }
    }
}
