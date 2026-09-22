using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day7___Structs_and_Enums
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("---- 1. EMPLOYEE & FLAGS ENUM TEST ----");
            Employee emp = new Employee("Alex", 5000, Role.Reception);

            Console.WriteLine("Initial Employee:");
            emp.DisplayData(); 

            emp.AssignRole(Role.Admin);
            emp.AssignRole(Role.Stock);

            Console.WriteLine("\nAfter Assigning Admin & Stock Roles:");
            emp.DisplayData(); 

            Console.WriteLine($"Has Admin Role? {emp.HasRole(Role.Admin)}");        
            Console.WriteLine($"Has Accountant Role? {emp.HasRole(Role.Accountant)}"); 

            Console.WriteLine("\n---- 2. POINT3D TEST ----");
            Point3D p1 = new Point3D(10, 20, 30);
            Point3D p2 = new Point3D { X = 10, Y = 20, Z = 30 }; 

            Console.Write("P1: ");
            p1.DisplayPoints();
            Console.Write("P2: ");
            p2.DisplayPoints();

            Console.WriteLine($"P1 == P2 : {p1 == p2}"); 

            p1.ChangeCoordinates(100, 200, 300);
            Console.Write("P1 After ChangeCoordinates: ");
            p1.DisplayPoints();
            Console.WriteLine($"P1 == P2 After Mutation: {p1 == p2}"); 

            
        }
    }
}
