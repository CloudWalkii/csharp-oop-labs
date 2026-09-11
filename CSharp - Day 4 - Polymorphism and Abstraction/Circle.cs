using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_4___Polymorphism_and_Abstraction
{
    class Circle : Shape
    {
        public double R;
        public Circle(double r)
        {
            R = r > 0 ? r : 0;
        }
        public override double CalculateArea()
        {
            return (Math.PI * R * R);
        }
    }
}
