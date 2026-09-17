using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day_6___Overriding_and_Inheritance
{
    internal class Program
    {
        static void Display(Point3D[] a)
        {
            foreach (Point3D item in a)
            {
                Console.WriteLine(item);
            }
        }
        public static void DisplayPerson(Person[] a)
        {
            foreach (Person item in a)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Point3D p1 = new Point3D { X = 10, Y = 20, Z = 30 }; // Object Initializer
            Point3D p2 = new Point3D(10, 20, 30);

            Console.WriteLine($"P1: {p1}");
            Console.WriteLine($"P2: {p2}");
            Console.WriteLine($"P1 == P2 : {p1 == p2}");
            Console.WriteLine($"P1.Equals(P2) : {p1.Equals(p2)}");

            Point3D[] points = new Point3D[]
            {
            p1,
            p2,
            new Point3D { X = 5, Y = 15 }
            };

            Console.WriteLine("\n--- Displaying Points Array ---");
            Display(points);

            // --- Task 2: Person Hierarchy & Polymorphism ---
            Address addr1 = new Address("Cairo", "90th Street", "11835");
            Address addr2 = new Address("Alexandria", "Corniche", "21500");

            Person[] people = new Person[]
        {
            new Employee("Alice", 30, addr1, "E1001", 85000),
            new Trainee("T2005", 22,"Bob", 42 ,addr2),
            new Employee("Charlie", 28, addr1, "E1002", 72000)
        };

            Console.WriteLine("\n--- Displaying People Collection ---");
            DisplayPerson(people);
        }
    }
}
