using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_labsDay02_ConstructorChaining
{
    class Fraction
    {
        public int numerator, denominator;

        public Fraction() : this(0, 1) { }
        public Fraction(int x) : this(x, 1)
        {
            numerator = x;
        }
        public Fraction(int x, int y)
        {
            numerator = x;
            denominator = (y == 0) ? 1 : y;
        }
        public void Display()
        {
            Console.WriteLine($"The Fraction is : {numerator}/{denominator}");
        }
        public Fraction FractionAdd(Fraction a, Fraction b)
        {
            int numerator2 = (a.numerator * b.denominator) + (b.numerator * a.denominator);
            int denominator2 = a.denominator * b.denominator;
            return new Fraction(numerator2, denominator2);
        }
        public Fraction Add(Fraction a)
        {
            return new Fraction(((a.numerator * denominator) + (numerator * a.denominator)), (a.denominator * denominator));
        }
    }
}
