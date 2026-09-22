using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp___Day7___Structs_and_Enums
{
    [Flags]
    enum Role
    {
        Admin = 1,
        Accountant = 2 ,
        Stock = 4,
        Reception = 8
    }
    struct Employee
    {
        public string Name;
        public decimal Salary;
        Role role;

        public Employee(string name) : this(name, 0, Role.Reception) { }

        public Employee(string name, decimal salary) : this(name, salary, Role.Reception) { }

        public Employee(string name, decimal salary, Role r)
        {
            Name = name;
            Salary = salary;
            role = r;
        }

        public void DisplayData()
        {
            Console.WriteLine($"Name : {Name}\tSalary = {Salary}\tRole : {role}");
        }
        public void AssignRole(Role r) => role |= r;

        public bool HasRole(Role r) => role.HasFlag(r);
       

        
    }
}
