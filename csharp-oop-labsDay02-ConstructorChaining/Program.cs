using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_labsDay02_ConstructorChaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction res = f1.Add(new Fraction(3, 2));
            res.Display();
        }
    }
}
